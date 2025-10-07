using Microsoft.AspNetCore.HttpOverrides;
using System.Threading.RateLimiting;

namespace TekSan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // --- Kestrel Limits ---
            builder.WebHost.ConfigureKestrel(options =>
            {
                // Sadece HTTP portu dinleniyor (HTTPS kald�r�ld�)
                options.ListenAnyIP(6543);

                options.Limits.MaxConcurrentConnections = 200;
                options.Limits.MaxConcurrentUpgradedConnections = 200;
                options.Limits.MaxRequestBodySize = 10 * 1024 * 1024; // 10 MB
                options.Limits.RequestHeadersTimeout = TimeSpan.FromSeconds(20);
            });

            // --- Reverse Proxy / CDN i�in g�venli IP alma ---
            builder.Services.Configure<ForwardedHeadersOptions>(opts =>
            {
                opts.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
                // Production'da sadece bilinen proxy'leri ekle
                // opts.KnownProxies.Add(IPAddress.Parse("203.0.113.5"));
            });

            // --- Rate Limiting ---
            builder.Services.AddRateLimiter(options =>
            {
                options.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>(httpContext =>
                {
                    var ip = httpContext.Connection.RemoteIpAddress?.ToString() ?? "unknown";
                    return RateLimitPartition.GetFixedWindowLimiter(ip, _ => new FixedWindowRateLimiterOptions
                    {
                        PermitLimit = 200,
                        Window = TimeSpan.FromMinutes(1),
                        QueueLimit = 0
                    });
                });

                options.AddPolicy("LoginPolicy", httpContext =>
                {
                    var ip = httpContext.Connection.RemoteIpAddress?.ToString() ?? "unknown";
                    return RateLimitPartition.GetTokenBucketLimiter(ip, _ => new TokenBucketRateLimiterOptions
                    {
                        TokenLimit = 10,
                        TokensPerPeriod = 5,
                        ReplenishmentPeriod = TimeSpan.FromMinutes(1),
                        AutoReplenishment = true
                    });
                });

                options.OnRejected = async (context, ct) =>
                {
                    context.HttpContext.Response.StatusCode = StatusCodes.Status429TooManyRequests;
                    context.HttpContext.Response.Headers.RetryAfter = "60";
                    await context.HttpContext.Response.WriteAsync("�ok fazla istek. L�tfen sonra tekrar dene.", ct);
                };
            });

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // --- Hata Sayfalar� (HSTS ve HTTPS y�nlendirmesi kald�r�ld�) ---
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // app.UseHsts(); // Nginx HTTPS terminasyonu yapt��� i�in kald�r�ld�
            }

            // app.UseHttpsRedirection(); // HTTPS y�nlendirmesi devre d��� b�rak�ld�
            app.UseStaticFiles();

            app.UseForwardedHeaders();
            app.UseRateLimiter();

            // --- G�venlik ba�l�klar� ---
            app.Use(async (ctx, next) =>
            {
                ctx.Response.Headers["X-Frame-Options"] = "SAMEORIGIN";
                ctx.Response.Headers["X-Content-Type-Options"] = "nosniff";
                ctx.Response.Headers["Referrer-Policy"] = "no-referrer";
                await next();
            });

            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}

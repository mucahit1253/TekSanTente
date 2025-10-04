using Microsoft.AspNetCore.HttpOverrides;
using System.Threading.RateLimiting;

namespace TekSan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // --- Kestrel / Server Limits (DoS'a dayanýklýlýk için) ---
            builder.WebHost.ConfigureKestrel(options =>
            {
                // Kapasitenize göre ayarlayýn
                options.Limits.MaxConcurrentConnections = 200;            // eþzamanlý baðlantý
                options.Limits.MaxConcurrentUpgradedConnections = 200;    // websocket vb.
                options.Limits.MaxRequestBodySize = 10 * 1024 * 1024;     // 10 MB upload sýnýrý
                options.Limits.RequestHeadersTimeout = TimeSpan.FromSeconds(20);
            });

            // --- Reverse Proxy/CDN arkasýnda gerçek IP almak için ---
            builder.Services.Configure<ForwardedHeadersOptions>(opts =>
            {
                opts.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
                // Production'da sadece bilinen proxy aðlarýný eklemen güvenli olur:
                // opts.KnownProxies.Add(IPAddress.Parse("1.2.3.4"));
                opts.KnownNetworks.Clear();
            });

            // --- Rate Limiting (Global + özel politikalar) ---
            builder.Services.AddRateLimiter(options =>
            {
                // Global: IP baþýna sabit pencere (örnek 200 istek/dk)
                options.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>(httpContext =>
                {
                    var ip = httpContext.Connection.RemoteIpAddress?.ToString() ?? "unknown";
                    return RateLimitPartition.GetFixedWindowLimiter(ip, _ => new FixedWindowRateLimiterOptions
                    {
                        PermitLimit = 200,
                        Window = TimeSpan.FromMinutes(1),
                        QueueLimit = 0,  // istek kuyruðu yok (hemen reddet)
                        QueueProcessingOrder = QueueProcessingOrder.OldestFirst
                    });
                });

                // Hassas endpoint (ör. /Account/Login) için daha sýký kova
                options.AddPolicy("LoginPolicy", httpContext =>
                {
                    var ip = httpContext.Connection.RemoteIpAddress?.ToString() ?? "unknown";
                    return RateLimitPartition.GetTokenBucketLimiter(ip, _ => new TokenBucketRateLimiterOptions
                    {
                        TokenLimit = 10,                   // kovadaki maksimum jeton
                        TokensPerPeriod = 5,               // dk baþýna eklenen jeton
                        ReplenishmentPeriod = TimeSpan.FromMinutes(1),
                        AutoReplenishment = true,
                        QueueLimit = 0,
                        QueueProcessingOrder = QueueProcessingOrder.OldestFirst
                    });
                });

                // Reddedilince 429 ve Retry-After
                options.OnRejected = async (context, ct) =>
                {
                    context.HttpContext.Response.StatusCode = StatusCodes.Status429TooManyRequests;
                    context.HttpContext.Response.Headers.RetryAfter = "60";
                    await context.HttpContext.Response.WriteAsync("Çok fazla istek. Lütfen sonra tekrar dene.", ct);
                };
            });

            // MVC
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Hata & HSTS
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            // Gerçek istemci IP'si
            app.UseForwardedHeaders();

            // Basit IP blocklist (opsiyonel)
            var blockedIps = new HashSet<string>
            {
                // "198.51.100.10", // örnek IP
            };
            app.Use(async (ctx, next) =>
            {
                var ip = ctx.Connection.RemoteIpAddress?.ToString();
                if (!string.IsNullOrEmpty(ip) && blockedIps.Contains(ip))
                {
                    ctx.Response.StatusCode = StatusCodes.Status403Forbidden;
                    await ctx.Response.WriteAsync("Forbidden");
                    return;
                }
                await next();
            });

            // Güvenlik baþlýklarý (özet)
            app.Use(async (ctx, next) =>
            {
                ctx.Response.Headers["X-Frame-Options"] = "SAMEORIGIN";
                ctx.Response.Headers["X-Content-Type-Options"] = "nosniff";
                ctx.Response.Headers["Referrer-Policy"] = "no-referrer";
                await next();
            });

            // Rate Limiter middleware (erken konumlandýr)
            app.UseRateLimiter();

            app.UseRouting();

            app.UseAuthorization();

            // Konvansiyonel route
            // NOT: Belirli bir aksiyona özel rate limit istiyorsan,
            // o controller/action'a [EnableRateLimiting("LoginPolicy")] attribute ekleyebilirsin.
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Örnek: belirli bir path’i politikaya baðlamak istersen (MVC dýþýnda):
            // app.MapPost("/Account/Login", () => Results.Ok()).RequireRateLimiting("LoginPolicy");

            ///test için kullanýldý.
            //app.MapGet("/test/ping", () => Results.Ok("pong"));
            //app.MapPost("/Account/Login", () => Results.Ok("login-ok"))
            //   .RequireRateLimiting("LoginPolicy");

            app.Run();
        }
    }
}

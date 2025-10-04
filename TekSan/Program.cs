using Microsoft.AspNetCore.HttpOverrides;
using System.Threading.RateLimiting;

namespace TekSan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // --- Kestrel / Server Limits (DoS'a dayan�kl�l�k i�in) ---
            builder.WebHost.ConfigureKestrel(options =>
            {
                // Kapasitenize g�re ayarlay�n
                options.Limits.MaxConcurrentConnections = 200;            // e�zamanl� ba�lant�
                options.Limits.MaxConcurrentUpgradedConnections = 200;    // websocket vb.
                options.Limits.MaxRequestBodySize = 10 * 1024 * 1024;     // 10 MB upload s�n�r�
                options.Limits.RequestHeadersTimeout = TimeSpan.FromSeconds(20);
            });

            // --- Reverse Proxy/CDN arkas�nda ger�ek IP almak i�in ---
            builder.Services.Configure<ForwardedHeadersOptions>(opts =>
            {
                opts.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
                // Production'da sadece bilinen proxy a�lar�n� eklemen g�venli olur:
                // opts.KnownProxies.Add(IPAddress.Parse("1.2.3.4"));
                opts.KnownNetworks.Clear();
            });

            // --- Rate Limiting (Global + �zel politikalar) ---
            builder.Services.AddRateLimiter(options =>
            {
                // Global: IP ba��na sabit pencere (�rnek 200 istek/dk)
                options.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>(httpContext =>
                {
                    var ip = httpContext.Connection.RemoteIpAddress?.ToString() ?? "unknown";
                    return RateLimitPartition.GetFixedWindowLimiter(ip, _ => new FixedWindowRateLimiterOptions
                    {
                        PermitLimit = 200,
                        Window = TimeSpan.FromMinutes(1),
                        QueueLimit = 0,  // istek kuyru�u yok (hemen reddet)
                        QueueProcessingOrder = QueueProcessingOrder.OldestFirst
                    });
                });

                // Hassas endpoint (�r. /Account/Login) i�in daha s�k� kova
                options.AddPolicy("LoginPolicy", httpContext =>
                {
                    var ip = httpContext.Connection.RemoteIpAddress?.ToString() ?? "unknown";
                    return RateLimitPartition.GetTokenBucketLimiter(ip, _ => new TokenBucketRateLimiterOptions
                    {
                        TokenLimit = 10,                   // kovadaki maksimum jeton
                        TokensPerPeriod = 5,               // dk ba��na eklenen jeton
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
                    await context.HttpContext.Response.WriteAsync("�ok fazla istek. L�tfen sonra tekrar dene.", ct);
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

            // Ger�ek istemci IP'si
            app.UseForwardedHeaders();

            // Basit IP blocklist (opsiyonel)
            var blockedIps = new HashSet<string>
            {
                // "198.51.100.10", // �rnek IP
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

            // G�venlik ba�l�klar� (�zet)
            app.Use(async (ctx, next) =>
            {
                ctx.Response.Headers["X-Frame-Options"] = "SAMEORIGIN";
                ctx.Response.Headers["X-Content-Type-Options"] = "nosniff";
                ctx.Response.Headers["Referrer-Policy"] = "no-referrer";
                await next();
            });

            // Rate Limiter middleware (erken konumland�r)
            app.UseRateLimiter();

            app.UseRouting();

            app.UseAuthorization();

            // Konvansiyonel route
            // NOT: Belirli bir aksiyona �zel rate limit istiyorsan,
            // o controller/action'a [EnableRateLimiting("LoginPolicy")] attribute ekleyebilirsin.
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // �rnek: belirli bir path�i politikaya ba�lamak istersen (MVC d���nda):
            // app.MapPost("/Account/Login", () => Results.Ok()).RequireRateLimiting("LoginPolicy");

            ///test i�in kullan�ld�.
            //app.MapGet("/test/ping", () => Results.Ok("pong"));
            //app.MapPost("/Account/Login", () => Results.Ok("login-ok"))
            //   .RequireRateLimiting("LoginPolicy");

            app.Run();
        }
    }
}

// (�rnek using'ler eksiksiz olsun)
using Microsoft.AspNetCore.HttpOverrides;
using System.Threading.RateLimiting;

var builder = WebApplication.CreateBuilder(args);

// Kestrel limits (senin ayarlar�n korunuyor)
builder.WebHost.ConfigureKestrel(options =>
{
    options.Limits.MaxConcurrentConnections = 200;
    options.Limits.MaxConcurrentUpgradedConnections = 200;
    options.Limits.MaxRequestBodySize = 10 * 1024 * 1024;
    options.Limits.RequestHeadersTimeout = TimeSpan.FromSeconds(20);
});

// Forwarded headers � Sadece g�vendi�in proxy'leri ekle!
// NOT: Production'da KnownProxies/Networks'i kendi CDN/LoadBalancer IP'lerinle doldur.
builder.Services.Configure<ForwardedHeadersOptions>(opts =>
{
    opts.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;

    // Danger: opts.KnownNetworks.Clear();  // Kald�rd�m � yerine g�venli proxy ekle
    // �rnek: tek bir proxy IP ekle (de�i�tir)
    // opts.KnownProxies.Add(IPAddress.Parse("203.0.113.5"));
});

// Rate limiter servis konfig�rasyonu (senin politikalar�n b�y�k �l��de korunuyor)
builder.Services.AddRateLimiter(options =>
{
    options.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>(httpContext =>
    {
        // G�venli client IP alma: X-Forwarded-For zaten ForwardedHeaders middleware taraf�ndan i�lenecek
        var ip = httpContext.Connection.RemoteIpAddress?.ToString() ?? "unknown";
        return RateLimitPartition.GetFixedWindowLimiter(ip, _ => new FixedWindowRateLimiterOptions
        {
            PermitLimit = 200,
            Window = TimeSpan.FromMinutes(1),
            QueueLimit = 0,
            QueueProcessingOrder = QueueProcessingOrder.OldestFirst
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
            AutoReplenishment = true,
            QueueLimit = 0
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

// Production hata & HSTS
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// ForwardedHeaders early � bunu RateLimiter'dan �nce �a��rmak �nemli
app.UseForwardedHeaders();

// Rate limiter'� m�mk�n oldu�unca erken �al��t�r (heavy pipeline �ncesi)
app.UseRateLimiter();

// Basit IP blocklist (�imdi RateLimiter'dan sonra veya �nce olabilir; loglamak istiyorsan burada tut)
// ... ayn� blocklist middleware ...

// G�venlik ba�l�klar�
// ...

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();




///test i�in kullan�ld�.
//app.MapGet("/test/ping", () => Results.Ok("pong"));
//app.MapPost("/Account/Login", () => Results.Ok("login-ok"))
//   .RequireRateLimiting("LoginPolicy");
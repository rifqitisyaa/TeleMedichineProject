using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TeleMedichineProject.Common;
using TeleMedichineProject.Helpers;
using TeleMedichineProject.Models;
using TeleMedichineProject.Models.Common;
using TeleMedichineProject.Models.TeleClass;
using TeleMedichineProject.Services;
using TeleMedichineProject.Hubs;
using TeleMedichineProject.Infrastructure;
using Microsoft.AspNetCore.OutputCaching;

var builder = WebApplication.CreateBuilder(args);

// Initialize Security Helpers
EncryptHelper.Initialize(builder.Configuration["EncryptionSettings:EncryptHelperKey"]);
EncDec.Initialize(builder.Configuration["EncryptionSettings:EncDecSalt"], builder.Configuration["EncryptionSettings:EncDecKey"]);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ErcDbContext>((serviceProvider, options) =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlOptions => sqlOptions.EnableRetryOnFailure(
            maxRetryCount: 5,
            maxRetryDelay: TimeSpan.FromSeconds(10),
            errorNumbersToAdd: null))
    .AddInterceptors(serviceProvider.GetRequiredService<AuditInterceptor>())
);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
    sqlOptions => sqlOptions.EnableRetryOnFailure(
            maxRetryCount: 5,
            maxRetryDelay: TimeSpan.FromSeconds(10),
            errorNumbersToAdd: null
            )
    ));

builder.Services.AddDbContext<CommonDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultCommonConnection"),
    sqlOptions => sqlOptions.EnableRetryOnFailure(
            maxRetryCount: 5,
            maxRetryDelay: TimeSpan.FromSeconds(10),
            errorNumbersToAdd: null
            )
    ));

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(8);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<AppUserLogin>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ITariffService, TariffService>();

// ── SignalR ──────────────────────────────────────────────
builder.Services.AddSignalR();

// ── OutputCache ──────────────────────────────────────────
builder.Services.AddOutputCache(options =>
{
    options.AddBasePolicy(b => b.Cache()); // default
    options.AddPolicy("5min",  b => b.Expire(TimeSpan.FromMinutes(5)));
    options.AddPolicy("1min",  b => b.Expire(TimeSpan.FromMinutes(1)));
    options.AddPolicy("30min", b => b.Expire(TimeSpan.FromMinutes(30)));
});

// ── PDF Service ──────────────────────────────────────────
builder.Services.AddScoped<IPdfService, PdfService>();

// ── Appointment Watcher (Background Service) ─────────────
builder.Services.AddHostedService<AppointmentWatcherService>();

// ── Audit Interceptor ────────────────────────────────────
builder.Services.AddScoped<AuditInterceptor>();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Login/Index";       // redirect kalau belum login
        options.AccessDeniedPath = "/Login/Index";

        options.Cookie.Name = "AuthCookie";       // optional (biar jelas)

        options.ExpireTimeSpan = TimeSpan.FromHours(8);
        options.SlidingExpiration = true;
    });

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(8);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseOutputCache();
app.UseRouting();

app.UseSession();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapHub<AppointmentHub>("/hubs/appointment");

app.Run();
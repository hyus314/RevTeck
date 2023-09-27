using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RevTech.Core.Contracts;
using RevTech.Core.Services;
using RevTech.Data;
using RevTech.Data.User;
using Microsoft.Extensions.Logging;
using System;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.AspNetCore.DataProtection;
using RevTech.Security;
using Stripe;

var builder = WebApplication.CreateBuilder(args);

StripeConfiguration.ApiKey = builder.Configuration.GetSection("StripeKeys")["SecretKey"];

// Add services to the container.
var defaultConnection = builder.Configuration.GetConnectionString("DefaultConnection");
var connectionString = builder.Configuration.GetConnectionString("DeployedConnection");
//var connectionString = Environment.GetEnvironmentVariable("DeployedConnection");
builder.Services.AddDbContext<RevtechDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddSingleton(provider =>
{
    var dataProtectionProvider = provider.GetService<IDataProtectionProvider>();
    return dataProtectionProvider.CreateProtector("ProtectConfigurationData");
});

builder.Services.AddSingleton<ConfigurationDataProtector>();

builder.Services.AddScoped<IVehicleService, VehicleService>();
builder.Services.AddScoped<IConfigurationService, ConfigurationService>();
builder.Services.AddScoped<IPerformancePartService, PerformancePartService>();
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddTransient<AdminService>();

builder.Services.AddDefaultIdentity<RevTeckUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = true;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = true;
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<RevtechDbContext>()
    .AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Events.OnRedirectToLogin = context =>
    {
        var currentUrl = context.RedirectUri;
        var newRedirectUrl = QueryHelpers.AddQueryString(currentUrl, "fromAuthController", "true");
        context.Response.Redirect(newRedirectUrl);
        return Task.CompletedTask;
    };
});

builder.Services.AddSession(options =>
{
    // Configure session options as needed
    options.IdleTimeout = TimeSpan.FromMinutes(20);
});


var app = builder.Build();

app.UseRouting();

// Forcing development-specific middleware regardless of environment
// WARNING: This is for demonstration purposes only and is not suitable for production!
{
    app.UseMigrationsEndPoint();
}

app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}"); // Handles status code
app.UseExceptionHandler("/Home/Error"); // Handles exception

app.UseHsts();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<RevtechDbContext>();
        context.Database.Migrate(); // apply all migrations

        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

        if (!roleManager.RoleExistsAsync("Admin").Result)
        {
            var role = new IdentityRole("Admin");
            var roleResult = roleManager.CreateAsync(role).Result;
        }

        if (!roleManager.RoleExistsAsync("User").Result)
        {
            var role = new IdentityRole("User");
            var roleResult = roleManager.CreateAsync(role).Result;
        }
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while migrating or initializing the database.");
    }
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();

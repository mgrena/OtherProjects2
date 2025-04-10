using Servier.Pressure.Services;
using Servier.Pressure.Components;
using Servier.Pressure.Components.Account;
using Servier.Pressure.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Servier.Pressure.Helpers;
using Microsoft.AspNetCore.Builder.Extensions;
using static System.Reflection.Metadata.BlobBuilder;
using Servier.Pressure.Interfaces;
using Servier.Pressure.Repositories;
using Servier.Pressure.Services.Pages;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDevExpressBlazor(options => {
    options.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5;
    options.SizeMode = DevExpress.Blazor.SizeMode.Small;
});
builder.Services.AddMvc();
builder.Services.AddControllers();

// configure services
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<PatientService>();
builder.Services.AddScoped<WorkplaceService>();
builder.Services.AddScoped<QuestionnaireService>();
builder.Services.AddSingleton<AppState>();

// add authentication
builder.Services.AddAuthentication(options => {
    options.DefaultScheme = IdentityConstants.ApplicationScheme;
    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
})
    .AddIdentityCookies();
builder.Services.Configure<SecurityStampValidatorOptions>(options =>
{
    options.ValidationInterval = TimeSpan.FromSeconds(60); // security stamp validity check interval (logs out the user if logged in elsewhere)
});

// configure DbContext
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
if (connectionString.Contains("Password"))
{
    string aPassword = builder.Configuration.GetConnectionString("pwd") ?? throw new InvalidOperationException("Password not found.");
    //aPassword = CryptFunctions.CryptPwd(aPassword);
    aPassword = CryptFunctions.AESDecryptString(aPassword);
    connectionString = string.Format(connectionString, aPassword);
}
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddIdentityCore<ApplicationUser>(options =>
    {
        options.SignIn.RequireConfirmedAccount = true;

        options.Password.RequireDigit = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequiredLength = 3;
        options.Password.RequiredUniqueChars = 1;
    })
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

// configure EmailSender
//string pass = CryptFunctions.CryptPwd(builder.Configuration.GetSection("SmtpOptions").GetValue<string>("Password")!);
builder.Services.Configure<SmtpOptions>(builder.Configuration.GetSection("SmtpOptions"));
builder.Services.AddSingleton<IEmailSender<ApplicationUser>, EmailSender>();

// configure Logger
builder.Logging.AddDbLogger();
builder.Services.AddSingleton<ILogs, LogRepository>();
builder.Services.AddHttpContextAccessor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapControllers();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AllowAnonymous();

app.MapAdditionalIdentityEndpoints();
app.Run();
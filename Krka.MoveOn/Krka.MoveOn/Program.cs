using Krka.MoveOn.Services;
using Krka.MoveOn.Components;
using Krka.MoveOn.Components.Account;
using Krka.MoveOn.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using static System.Reflection.Metadata.BlobBuilder;
using Krka.MoveOn.Interfaces;
using Krka.MoveOn.Repositories;
using Krka.MoveOn.Services.Questionnaires;
using Krka.MoveOn.Services.Pages;
using Blazored.LocalStorage;
using Blazored.SessionStorage;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddServerSideBlazor()
    .AddCircuitOptions(options => { options.DetailedErrors = true; });

builder.Services.AddDevExpressBlazor(options => {
    options.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5;
    options.SizeMode = DevExpress.Blazor.SizeMode.Small;
});
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddMvc();

// configure services
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<PatientService>();
builder.Services.AddScoped<General01Service>();
builder.Services.AddScoped<Initial02Service>();
builder.Services.AddScoped<Treatment03Service>();
builder.Services.AddScoped<Motor04Service>();
builder.Services.AddScoped<Motor05Service>();
builder.Services.AddScoped<Motor06Service>();
builder.Services.AddScoped<Moca07Service>();
builder.Services.AddScoped<Exclusion08Service>();
builder.Services.AddScoped<QuestionnaireService>();
builder.Services.AddTransient<DrugEffect09Service>(); 
builder.Services.AddScoped<Satisfaction10Service>();
builder.Services.AddScoped<QuestionnaireProgressService>();

// add authentication
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredSessionStorage();

builder.Services.Configure<SecurityStampValidatorOptions>(o => o.ValidationInterval = TimeSpan.FromSeconds(30));
builder.Services.ConfigureApplicationCookie(options =>
{
    options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
    options.SlidingExpiration = true;
});

builder.Services.AddAuthentication(options => {
    options.DefaultScheme = IdentityConstants.ApplicationScheme;
    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
})
    .AddIdentityCookies();

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
    options.UseSqlServer(connectionString), ServiceLifetime.Transient);
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();
builder.Services.AddScoped<UserManager<ApplicationUser>>();

// configure EmailSender
builder.Services.Configure<SmtpOptions>(builder.Configuration.GetSection("SmtpOptions"));
builder.Services.AddSingleton<IEmailSender<ApplicationUser>, EmailSender>();

// configure Logger
builder.Logging.AddDbLogger();
builder.Services.AddSingleton<ILogs, LogRepository>();
builder.Services.AddHttpContextAccessor();

var app = builder.Build();

string[] supportedCultures = [ "en-US", "cs-CZ", "sk-SK" ];
app.UseRequestLocalization(new RequestLocalizationOptions()
    .SetDefaultCulture(supportedCultures[0])
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures));

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseMigrationsEndPoint();
} else {
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapControllers();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapAdditionalIdentityEndpoints();
DevExpress.Utils.Localization.XtraLocalizer.EnableTraceSource();
app.Run();
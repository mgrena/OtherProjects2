using Microsoft.Extensions.Configuration;

using Vetoquinol.API.Contracts;
using Vetoquinol.DataAccess;
using Vetoquinol.Import;
using Vetoquinol.Import.Contracts;

var aConfig = new ConfigurationBuilder()
      .SetBasePath(Directory.GetCurrentDirectory())
      .AddJsonFile("appsettings.json", optional: false);

IConfiguration config = aConfig.Build();

// Application settings
var anAppSettings = config.GetSection("AppSettings").Get<AppSettings>();
if (anAppSettings == null)
{
    Processes.WriteMessage("AppSettings can't be null!");
    return;
}

// DB connection
string aConnString = config.GetSection("DBSettings").GetValue<string>("ConnectionString") ?? "";
//Processes.CryptPwd(config.GetSection("DBSettings").GetValue<string>("pwd")!);
string aPassword = CryptFunctions.AESDecryptString(config.GetSection("DBSettings").GetValue<string>("pwd")!);
if (aConnString.Contains("Password"))
    aConnString = string.Format(aConnString, aPassword);
DataAccessSettings.DBConnectionString = aConnString;

var aDBContext = new VetoquinolSourceDataContext();
if (aDBContext == null || !aDBContext.Database.CanConnect())
{
    Processes.WriteMessage("Failed to connect to the database!");
    return;
}

// API settings
var clients = config.GetSection("Clients").Get<Credentials[]>() ?? [];
foreach (var client in clients)
    ApiSettings.Clients.Add(client.Id, client);

Processes.WriteMessage("Process start");
DateTime aStartTime = DateTime.Now;
DateTime aStartInterval = aStartTime.AddDays(-1 * (7 + (aStartTime.DayOfWeek - DayOfWeek.Monday))).Date;
DateTime anEndInterval = aStartInterval.AddDays(6);

var aResult = Processes.ProcessBatchAsync(anAppSettings, aStartInterval, anEndInterval).Result;
//var aResult = Processes.ProcessBatchAsync(anAppSettings, new DateTime(2025, 1, 1), new DateTime(2025, 1, 31)).Result;
if (aResult.Status)
    Processes.WriteMessage(String.Format("Completed, duration = {0}", new TimeSpan(DateTime.Now.Subtract(aStartTime).Ticks).ToString()));
else
    Processes.WriteMessage("Completed with errors");

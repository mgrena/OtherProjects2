using Servier.Pressure.Data;
using Servier.Pressure.Interfaces;

namespace Servier.Pressure.Repositories;

/// <summary>
/// Repository for methods for working with logging
/// </summary>
public class LogRepository(IServiceScopeFactory scopeFactory) : ILogs
{
    private readonly IServiceScopeFactory myScopeFactory = scopeFactory;
    private static object myLock = new();

    /// <summary>
    /// Stores logging entry in database
    /// </summary>
    public async Task Log(LogEntity entity)
    {
        using var scope = myScopeFactory.CreateScope();
        try
        {
            var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            aContext.Logs.Add(entity);
            await aContext.SaveChangesAsync();
        }
        catch (Exception? ex)
        {
            lock (myLock)
            {
                string aLogFile = getLogFile();
                using StreamWriter sw = new(File.Open(aLogFile, FileMode.Append));
                while (ex != null)
                {
                    sw.WriteLine(string.Format("{0} {1}", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"), ex.Message));
                    sw.WriteLine(string.Format("{0} {1}", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"), ex.StackTrace));
                    ex = ex.InnerException;
                }
            }
        }
    }
    private static string getLogFile()
    {
        string aLogFileDefaultName = "backup_log.log";
        string aLogDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log");
        if (!Directory.Exists(aLogDirectory))
            Directory.CreateDirectory(aLogDirectory);

        if (File.Exists(Path.Combine(aLogDirectory, aLogFileDefaultName)))
        {
            long aLogFileSize = new FileInfo(Path.Combine(aLogDirectory, aLogFileDefaultName)).Length;
            if (aLogFileSize > 1024 * 1024 * 10)
            {
                int aFileCount = Directory.GetFiles(aLogDirectory, "*.log").Length;
                string aNewFileName = aLogFileDefaultName.Replace(".", string.Format("_{0}.", aFileCount));
                File.Move(Path.Combine(aLogDirectory, aLogFileDefaultName), Path.Combine(aLogDirectory, aNewFileName));
                File.Create(Path.Combine(aLogDirectory, aLogFileDefaultName)).Close();
            }
        }
        else
        {
            File.Create(Path.Combine(aLogDirectory, aLogFileDefaultName)).Close();
        }

        return Path.Combine(aLogDirectory, aLogFileDefaultName);
    }
}

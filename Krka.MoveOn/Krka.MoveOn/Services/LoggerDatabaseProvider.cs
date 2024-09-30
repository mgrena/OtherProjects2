using static System.Reflection.Metadata.BlobBuilder;
using System.Reflection;
using Krka.MoveOn.Interfaces;
using Krka.MoveOn.Data;

namespace Krka.MoveOn.Services;

/// <summary>
/// Custom logger provider to store log entries in database
/// </summary>
public class LoggerDatabaseProvider : ILoggerProvider
{
    private readonly ILogs myLogs;

    /// <summary>
    /// Custom logger provider to store log entries in database
    /// </summary>
    public LoggerDatabaseProvider(ILogs logs)
    {
        this.myLogs = logs;
    }

    /// <inheritdoc/>
    public ILogger CreateLogger(string categoryName)
    {
        return new DbLogger(categoryName, myLogs);
    }

    /// <inheritdoc/>
    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Custom logger to store log entries in database
    /// </summary>
    public class DbLogger : ILogger
    {
        private readonly string myCategoryName;
        private readonly ILogs myLogs;

        /// <summary>
        /// Custom logger to store log entries in database
        /// </summary>
        /// <param name="category">name of log category (e.g. class name)</param>
        /// <param name="logs">interface to repository</param>
        public DbLogger(string category, ILogs logs)
        {
            this.myCategoryName = category;
            this.myLogs = logs;
        }

        /// <inheritdoc/>
        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel != LogLevel.None;
        }

        /// <inheritdoc/>
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                // Don't log the entry if it's not enabled.
                return;
            }
            //var threadId = Thread.CurrentThread.ManagedThreadId; // Get the current thread ID to use in the log file. 

            int anUserId = 0;
            if (state != null)
            {
                FieldInfo[] anInfos = state.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
                FieldInfo? aProps = anInfos.FirstOrDefault(o => o.Name == "_values");
                if (aProps != null)
                {
                    object? aPropValue = aProps.GetValue(state);
                    if (aPropValue != null)
                    {
                        object[] aValues = (object[])aPropValue;
                        if (aValues != null && aValues.Length > 0 && aValues.Last() is int @int)
                            anUserId = @int;
                    }
                }
            }

            var aLog = new LogEntity()
            {
                LogLevel = logLevel.ToString(),
                Category = myCategoryName,
                UserId = anUserId,
                CreatedAt = DateTime.Now,
                Message = formatter(state, exception)
            };
            myLogs.Log(aLog);

            // handle exceptions
            if (exception != null)
            {
                while (exception != null)
                {
                    aLog = new LogEntity()
                    {
                        LogLevel = logLevel.ToString(),
                        Category = "details",
                        UserId = anUserId,
                        CreatedAt = DateTime.Now,
                        Message = exception.Message
                    };
                    myLogs.Log(aLog);
                    aLog = new LogEntity()
                    {
                        LogLevel = logLevel.ToString(),
                        Category = "details",
                        UserId = anUserId,
                        CreatedAt = DateTime.Now,
                        Message = exception.StackTrace
                    };
                    myLogs.Log(aLog);
                    exception = exception.InnerException;
                }
            }
        }

        /// <inheritdoc/>
        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            return new NoopDisposable();
        }

        private class NoopDisposable : IDisposable
        {
            public void Dispose()
            {
            }
        }
    }
}

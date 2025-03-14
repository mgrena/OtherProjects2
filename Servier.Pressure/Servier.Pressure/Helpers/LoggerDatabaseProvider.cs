using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging.Configuration;
using Servier.Pressure.Data;
using Servier.Pressure.Interfaces;
using static System.Reflection.Metadata.BlobBuilder;

namespace Servier.Pressure.Helpers;

/// <summary>
/// Custom logger provider to store log entries in database
/// </summary>
public class LoggerDatabaseProvider(ILogs logs, IServiceProvider serviceProvider) : ILoggerProvider
{
    private readonly ILogs myLogs = logs;
    private readonly IServiceProvider myServiceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));

    /// <inheritdoc/>
    public ILogger CreateLogger(string categoryName)
    {
        return new DbLogger(categoryName, myLogs, myServiceProvider);
    }

    /// <inheritdoc/>
    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Custom logger to store log entries in database
    /// </summary>
    /// <param name="category">name of log category (e.g. class name)</param>
    /// <param name="logs">interface to repository</param>
    public class DbLogger(string category, ILogs logs, IServiceProvider serviceProvider) : ILogger
    {
        private readonly string myCategoryName = category;
        private readonly ILogs myLogs = logs;
        private readonly IServiceProvider myServiceProvider = serviceProvider;

        /// <inheritdoc/>
        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel != LogLevel.None;
        }

        /// <inheritdoc/>
        public async void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                // Don't log the entry if it's not enabled.
                return;
            }

            using var scope = myServiceProvider.CreateScope();
            var userManager = scope.ServiceProvider.GetService<UserManager<ApplicationUser>>();
            var httpContextAccessor = scope.ServiceProvider.GetService<IHttpContextAccessor>();

            string anUserId = "0";
            if (userManager != null && httpContextAccessor != null && httpContextAccessor.HttpContext != null)
            {
                var user = userManager.GetUserAsync(httpContextAccessor.HttpContext.User).Result;
                if (user != null)
                    anUserId = user.Id;
            }

            var aLog = new LogEntity()
            {
                LogLevel = logLevel.ToString(),
                Category = myCategoryName,
                UserId = anUserId,
                CreatedAt = DateTime.Now,
                Message = formatter(state, exception)
            };
            await myLogs.Log(aLog);

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
                    _ = myLogs.Log(aLog);
                    if (exception.StackTrace != null)
                    {
                        aLog = new LogEntity()
                        {
                            LogLevel = logLevel.ToString(),
                            Category = "details",
                            UserId = anUserId,
                            CreatedAt = DateTime.Now,
                            Message = exception.StackTrace
                        };
                        _ = myLogs.Log(aLog);
                    }
                    exception = exception.InnerException;
                }
            } // if (exception != null)
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
public static class DbLoggerExtensions
{
    public static ILoggingBuilder AddDbLogger(this ILoggingBuilder builder)
    {
        builder.AddConfiguration();
        builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<ILoggerProvider, LoggerDatabaseProvider>());
        LoggerProviderOptions.RegisterProviderOptions<DbLoggerOptions, LoggerDatabaseProvider>(builder.Services);

        return builder;
    }
    public static ILoggingBuilder AddDbLogger(this ILoggingBuilder builder, Action<DbLoggerOptions> configure)
    {
        builder.AddDbLogger();
        builder.Services.Configure(configure);

        return builder;
    }
}

public class DbLoggerOptions
{
}

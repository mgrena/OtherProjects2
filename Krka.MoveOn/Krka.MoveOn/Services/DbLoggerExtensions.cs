using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging.Configuration;

namespace Krka.MoveOn.Services;

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

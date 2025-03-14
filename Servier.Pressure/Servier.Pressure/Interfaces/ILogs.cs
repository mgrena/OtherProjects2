using Servier.Pressure.Data;

namespace Servier.Pressure.Interfaces;

/// <summary>
/// Interface to access logs data
/// </summary>
public interface ILogs
{
    /// <summary>
    /// Log entity to database
    /// </summary>
    Task Log(LogEntity entity);
}

namespace Vetoquinol.API.Contracts.Reporting;

public class ResultReport
{
    public ResultReport()
    {
        Statuses = new Dictionary<string, StatusReport>();
        RetunObjects = new Dictionary<string, object?>();
    }
    public IDictionary<string, StatusReport> Statuses { get; }
    public IDictionary<string, object?> RetunObjects { get; }
}

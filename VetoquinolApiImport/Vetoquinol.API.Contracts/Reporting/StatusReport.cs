namespace Vetoquinol.API.Contracts.Reporting;

public class StatusReport
{
    public bool Status { get; set; }
    public ApiError? Error { get; set; }
}

namespace Vetoquinol.API.Contracts.Reporting;

public class ApiError
{
    public Error[]? Errors { get; set; }

}
public class Error
{
    public int Status { get; set; }
    public string? Phrase { get; set; }
    public string? Detail { get; set; }
    public string? StackTrace { get; set; }
}

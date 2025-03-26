namespace Servier.Pressure.Helpers;

public class OperationResult
{
    public bool Success { get; set; }
    public string? ErrorMessage { get; set; }
    public string? AdditionalInfo { get; set; }

    public static OperationResult SuccessResult() => new() { Success = true };
    public static OperationResult FailureResult(string errorMessage, string? additionalInfo = null)
        => new() { Success = false, ErrorMessage = errorMessage, AdditionalInfo = additionalInfo };
}

namespace Vetoquinol.API.Contracts;

public static class ApiSettings
{
    public static IDictionary<int, Credentials> Clients { get; } = new Dictionary<int, Credentials>();
}
public class Credentials
{
    public int Id { get; set; }
    public required string Client { get; set; }
    public required string Account { get; set; }
    public required string Password { get; set; }
    public required string BaseUri { get; set; }
}

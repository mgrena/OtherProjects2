namespace Vetoquinol.Topvet.Sk.API.Contracts;

internal class PharmacyContract
{
    public int clientApiId { get; set; }
    public int clientId { get; set; }
    public string? ico { get; set; }
    public string? name { get; set; }
    public string? city { get; set; }
    public string? street { get; set; }
    public string? email { get; set; }
    public int centerId { get; set; }
    public string? centerCode { get; set; }
}

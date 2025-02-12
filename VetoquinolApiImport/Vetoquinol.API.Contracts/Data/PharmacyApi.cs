namespace Vetoquinol.API.Contracts.Data;

public class PharmacyApi
{
    public int DistrId { get; set; }
    public int ClientApiId { get; set; }
    public int ClientIdInt { get; set; }
    public string? ClientId { get; set; }
    public string? ClientMasterId { get; set; }
    public string? PreviousMasterId { get; set; }
    public string? Name { get; set; }
    public string? Name2 { get; set; }
    public string? Address { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }
    public string? Ico { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? RegNo { get; set; }
    public string? RegName { get; set; }
    public int CenterId { get; set; }
    public string? CenterCode { get; set; }
    public bool Canceled { get; set; }
    public bool Priceless { get; set; }
}

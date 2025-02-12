namespace Vetoquinol.Topvet.Sk.API.Contracts;

internal class ProductContract
{
    public int id { get; set; }
    public string? productId { get; set; }
    public string? code { get; set; }
    public string? name { get; set; }
    public int vat { get; set; }
    public decimal catalogPrice { get; set; }
    public int centerId { get; set; }
    public string? centerCode { get; set; }
    public string? ean { get; set; }
    public string? producer_name { get; set; }
    public string? assortment_name { get; set; }
    public string? regNumber { get; set; }
    public string? packNumber { get; set; }
    public bool available { get; set; }
}

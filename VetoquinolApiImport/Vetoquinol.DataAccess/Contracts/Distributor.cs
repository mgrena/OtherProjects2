namespace Vetoquinol.DataAccess.Contracts;

public partial class Distributor
{
    public int Id { get; set; }

    public string Country { get; set; } = null!;

    public string Name { get; set; } = null!;
}

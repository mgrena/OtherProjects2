using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servier.Pressure.Data.Lists;

[Table("list_dyslipidemia_drugs")]
public class DyslipidemiaDrug
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("drug", TypeName = "nvarchar"), StringLength(255)]
    public required string Name { get; set; } = string.Empty;

    [Column("created_at")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
    [Column("modified_at")]
    public required DateTime ModifiedAt { get; set; } = DateTime.Now;
    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }
}

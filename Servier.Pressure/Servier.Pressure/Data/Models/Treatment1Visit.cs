using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servier.Pressure.Data.Models;

[Table("treatments_1_visit")]
public class Treatment1Visit
{
    [Key]
    [Column("id", TypeName = "nvarchar"), StringLength(450)]
    public required string Id { get; set; }


    [Column("modified_at")]
    public required DateTime ModifiedAt { get; set; } = DateTime.Now;
    [Column("created_at")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
}

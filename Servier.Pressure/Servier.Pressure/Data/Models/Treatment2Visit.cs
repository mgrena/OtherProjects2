using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servier.Pressure.Data.Models;

[Table("treatments_2_visit")]
public class Treatment2Visit
{
    [Key]
    [Column("id", TypeName = "nvarchar"), StringLength(450)]
    public required string Id { get; set; }
    [Column("is_changed")]
    public bool IsChanged { get; set; } = false;
    [Column("fix_combination_3_unknown")]
    public bool FixCombination3Unknown { get; set; } = false;
    [Column("fix_combination_mix_unknown")]
    public bool FixCombinationMixUnknown { get; set; } = false;

    [Column("modified_at")]
    public required DateTime ModifiedAt { get; set; } = DateTime.Now;
    [Column("created_at")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
}

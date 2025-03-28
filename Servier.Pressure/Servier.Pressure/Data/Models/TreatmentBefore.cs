using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servier.Pressure.Data.Models;

[Table("treatments_before")]
public class TreatmentBefore
{
    [Key]
    [Column("id", TypeName = "nvarchar"), StringLength(450)]
    public required string Id { get; set; }

    [Column("diag_dyslipidemia_drug")]
    public int DiagnosisDyslipidemiaDrug { get; set; } = 0;
    [Column("gp")]
    public bool GeneralPractitioner { get; set; } = false;
    [Column("diabetologist")]
    public bool Diabetologist { get; set; } = false;
    [Column("geriatrician")]
    public bool Geriatrician { get; set; } = false;
    [Column("internist")]
    public bool Internist { get; set; } = false;
    [Column("cardiologist")]
    public bool Cardiologist { get; set; } = false;
    [Column("other", TypeName = "nvarchar"), StringLength(150)]
    public string? Other { get; set; }
    [Column("fix_combination_3_unknown")]
    public bool FixCombination3Unknown { get; set; } = false;
    [Column("fix_combination_mix_unknown")]
    public bool FixCombinationMixUnknown { get; set; } = false;

    [Column("modified_at")]
    public required DateTime ModifiedAt { get; set; } = DateTime.Now;
    [Column("created_at")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
}

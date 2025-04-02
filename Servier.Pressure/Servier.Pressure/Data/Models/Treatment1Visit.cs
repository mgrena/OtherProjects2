using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servier.Pressure.Data.Models;

public enum AnswerEnum
{
    yes = 0,
    no = 1,
    notapplicable = 2
}

[Table("treatments_1_visit")]
public class Treatment1Visit
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
    [Column("is_ongoing")]
    public bool IsOngoing { get; set; } = false;
    [Column("is_issuing_recorder")]
    public AnswerEnum IsIssuingRecorder { get; set; } = AnswerEnum.yes;
    [Column("is_pressure_gauge")]
    public AnswerEnum IsPressureGauge { get; set; } = AnswerEnum.yes;

    [Column("modified_at")]
    public required DateTime ModifiedAt { get; set; } = DateTime.Now;
    [Column("created_at")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
}

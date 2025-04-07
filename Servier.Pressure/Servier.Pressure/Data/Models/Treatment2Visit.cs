using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servier.Pressure.Data.Models;

public enum EvaluationEnum
{
    [Display(Name = "výborná")]
    excellent = 1,
    [Display(Name = "dobrá")]
    good = 2,
    [Display(Name = "uspokojivá")]
    satisfactory = 3,
    [Display(Name = "zlá")]
    bad = 4,
    [Display(Name = "veľmi zlá")]
    verybad = 5
}
public enum TerminationReasonEnum
{
    [Display(Name = "---")]
    none = 0,
    [Display(Name = "subjekt neprišiel na Návštevu 2")]
    notcome = 1,
    [Display(Name = "subjekt odvolal informovaný súhlas")]
    consent = 2,
    [Display(Name = "účasť subjektu ukončená skúšajúcim")]
    terminatedInvestigator = 3,
    [Display(Name = "účasť subjektu ukončená etickou komisiou / regulačným úradom")]
    terminatedAuthority = 4
}

[Table("treatments_2_visit")]
public class Treatment2Visit
{
    [Key]
    [Column("id", TypeName = "nvarchar"), StringLength(450)]
    public required string Id { get; set; }

    [Column("visit_date")]
    public DateTime? VisitDate { get; set; } = DateTime.Now;
    [Column("is_returned_recorder")]
    public bool IsReturnedRecorder { get; set; } = false;
    [Column("subject_evaluation")]
    public EvaluationEnum SubjectEvaluation { get; set; } = EvaluationEnum.excellent;
    [Column("is_properly_terminated")]
    public bool IsProperlyTerminated { get; set; } = true;
    [Column("termination_reason")]
    public TerminationReasonEnum TerminationReason { get; set; } = TerminationReasonEnum.none;

    [Column("is_changed")]
    public bool IsChanged { get; set; } = false;
    [Column("change_date")]
    public DateTime? ChangeDate { get; set; } = DateTime.Now;
    [Column("is_change_date_unknown")]
    public bool IsChangeDateUnknown { get; set; } = false;
    [Column("fix_combination_3_unknown")]
    public bool FixCombination3Unknown { get; set; } = false;
    [Column("fix_combination_mix_unknown")]
    public bool FixCombinationMixUnknown { get; set; } = false;

    [Column("modified_at")]
    public required DateTime ModifiedAt { get; set; } = DateTime.Now;
    [Column("created_at")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
}

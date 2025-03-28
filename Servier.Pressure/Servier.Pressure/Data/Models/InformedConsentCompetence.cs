using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servier.Pressure.Data.Models;

[Table("infos")]
public class InformedConsentCompetence
{
    [Key]
    [Column("id", TypeName = "nvarchar"), StringLength(450)]
    public required string Id { get; set; }

    [Required]
    [Column("is_consent")]
    public required bool IsConsent { get; set; } = true;
    [Required]
    [Column("is_adult")]
    public required bool IsAdult { get; set; } = true;
    [Required]
    [Column("is_stable_hypertension")]
    public required bool IsStableHypertension { get; set; } = true;
    [Required]
    [Column("is_informed_consent")]
    public required bool IsInformedConsent { get; set; } = true;

    [Required]
    [Column("is_already_enrolled")]
    public required bool IsAlreadyEnrolled { get; set; } = false;
    [Required]
    [Column("is_resistant_hypertension")]
    public required bool IsResistantHypertension { get; set; } = false;
    [Required]
    [Column("is_clinical_trial")]
    public required bool IsClinicalTrial { get; set; } = false;
    [Required]
    [Column("is_pregnant")]
    public required bool IsPregnant { get; set; } = false;

    [Column("visit_date")]
    public required DateTime VisitDate { get; set; } = DateTime.Now;

    [Column("modified_at")]
    public required DateTime ModifiedAt { get; set; } = DateTime.Now;
    [Column("created_at")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
}

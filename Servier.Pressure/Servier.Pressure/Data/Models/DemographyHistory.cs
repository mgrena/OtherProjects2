using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servier.Pressure.Data.Models;

public enum SmokerEnum
{
    [Display(Name = "fajčiar")]
    smoker = 1,
    [Display(Name = "nefajčiar")]
    nonsmoker = 2,
    [Display(Name = "ex-fajčiar")]
    exsmoker = 3
}

public enum EducationEnum
{
    [Display(Name = "základné")]
    elementary = 1,
    [Display(Name = "stredoškolské")]
    secondary = 2,
    [Display(Name = "vysokoškolské")]
    university = 3
}

public enum AngiographyEnum
{
    [Display(Name = "koronárna angiografia")]
    angiography = 1,
    [Display(Name = "počítačová tomografia (CT)")]
    ct = 2
}

public enum RevascularizationEnum
{
    [Display(Name = "perkutánna koronárna intervencia (PCI)")]
    pci = 1,
    [Display(Name = "by-pass koronárnej artérie (CABG)")]
    cabg = 2
}

public enum KidneyDiseaseEnum
{
    [Display(Name = "G1 (GF ≥ 90 ml/min / 1.73 m2)")]
    G1 = 1,
    [Display(Name = "G2 (GF 60 – 89 ml/min / 1.73 m2)")]
    G2 = 2,
    [Display(Name = "G3a (GF 45 – 59 ml/min / 1.73 m2)")]
    G3a = 3,
    [Display(Name = "G3b (GF 30 - 44 ml/min / 1.73 m2)")]
    G3b = 4,
    [Display(Name = "G4 (GF 15 - 29 ml/min / 1.73 m2)")]
    G4 = 5,
    [Display(Name = "G5 (GF < 15 ml/ min / 1.73 m2)")]
    G5 = 6,
    [Display(Name = "neznáme")]
    unknown = 7
}

[Table("demographies")]
public class DemographyHistory
{
    /// <summary>
    /// Relevant Patient Id used as key
    /// </summary>
    [Key]
    [Column("id", TypeName = "nvarchar"), StringLength(450)]
    public required string Id { get; set; }

    [Required]
    [Column("is_man")]
    public required bool IsMan { get; set; }
    [Required]
    [Column("age")]
    public required int Age { get; set; }
    [Column("smoker")]
    public SmokerEnum Smoker { get; set; } = 0;
    [Column("education")]
    public EducationEnum Education { get; set; } = 0;

    [Column("diagnosis_year")]
    public int DiagnosisYear { get; set; } = 0;
    [Column("diagnosis_year_unknown")]
    public bool DiagnosisYearUnknown { get; set; } = false;
    [Column("treatment_year")]
    public int TreatmentYear { get; set; } = 0;
    [Column("treatment_year_unknown")]
    public bool TreatmentYearUnknown { get; set; } = false;

    [Column("diag_none")]
    public bool DiagnosisNone { get; set; } = false;
    [Column("diag_diabetes")]
    public bool DiagnosisDiabetes { get; set; } = false;
    [Column("diag_diabetes_type")]
    public int DiagnosisDiabetesType { get; set; } = 0;
    [Column("diag_dyslipidemia")]
    public bool DiagnosisDyslipidemia { get; set; } = false;
    [Column("diag_dyslipidemia_drug")]
    public int DiagnosisDyslipidemiaDrug { get; set; } = 0;
    [Column("diag_ICHS")]
    public bool DiagnosisICHS { get; set; } = false;
    [Column("diag_ICHS_infarction")]
    public bool DiagnosisICHSInfarction { get; set; } = false;
    [Column("diag_ICHS_angina")]
    public bool DiagnosisICHSAngina { get; set; } = false;
    [Column("diag_ICHS_angiography")]
    public bool DiagnosisICHSAngiography { get; set; } = false;
    [Column("diag_ICHS_angiography_type")]
    public AngiographyEnum DiagnosisICHSAngiographyType { get; set; } = 0;
    [Column("diag_ICHS_revascularization")]
    public bool DiagnosisICHSRevascularization { get; set; } = false;
    [Column("diag_ICHS_revascularization_type")]
    public RevascularizationEnum DiagnosisICHSRevascularizationType { get; set; } = 0;
    [Column("diag_failure")]
    public bool DiagnosisHeartFailure { get; set; } = false;
    [Column("diag_fibrillation")]
    public bool DiagnosisFibrillation { get; set; } = false;
    [Column("diag_stroke")]
    public bool DiagnosisStroke { get; set; } = false;
    [Column("diag_arteriald")]
    public bool DiagnosisArterialD { get; set; } = false;
    [Column("diag_insufficiency")]
    public bool DiagnosisInsufficiency { get; set; } = false;
    [Column("diag_kidneyd")]
    public bool DiagnosisKidneyD { get; set; } = false;
    [Column("diag_kidneyd_type")]
    public KidneyDiseaseEnum DiagnosisKidneyDType { get; set; } = 0;

    [Column("modified_at")]
    public required DateTime ModifiedAt { get; set; } = DateTime.Now;
    [Column("created_at")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
}

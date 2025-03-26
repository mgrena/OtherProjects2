using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Servier.Pressure.Data.Models;

/// <summary>
/// Type: Ambulance = 1, Hospital = 2
/// </summary>
public enum WorkplaceTypeEnum
{
    [Display(Name = "ambulancia")]
    Ambulance = 1,
    /// <summary>
    /// nemocničné oddelenie alebo klinika
    /// </summary>
    [Display(Name = "nemocničné oddelenie alebo klinika")]
    Hospital = 2
}
public enum SpecializationEnum
{
    [Display(Name = "diabetológ")]
    diabetologist = 1,
    [Display(Name = "geriater")]
    geriatrician = 2,
    [Display(Name = "internista")]
    internist = 3,
    [Display(Name = "kardiológ")]
    cardiologist = 4,
    [Display(Name = "všeobecný lekár")]
    general = 5,
    [Display(Name = "iná")]
    other = 6
}

[Table("workplaces")]
public class WorkPlace
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("workplace_type")]
    public WorkplaceTypeEnum WorkplaceType { get; set; } = WorkplaceTypeEnum.Ambulance;
    [Column("specialization")]
    public SpecializationEnum Specialization { get; set; } = SpecializationEnum.other;
    [Column("count_all")]
    public int PatientsCountAll { get; set; } = 0;
    [Column("count_all_unknown")]
    public bool PatientsCountAllUnknown { get; set; } = false;
    [Column("count_AH")]
    public int PatientsCountAH { get; set; } = 0;
    [Column("count_AH_unknown")]
    public bool PatientsCountAHUnknown { get; set; } = false;
    [Column("workplace", TypeName = "nvarchar"), StringLength(255)]
    public required string Workplace { get; set; } = string.Empty;
    [Required]
    [Column("id_user", TypeName = "nvarchar"), StringLength(450)]
    public required string UserId { get; set; }
    [Column("created_at")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }
}

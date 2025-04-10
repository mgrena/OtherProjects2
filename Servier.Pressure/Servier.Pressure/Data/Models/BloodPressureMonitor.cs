using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servier.Pressure.Data.Models;

[Table("blood_pressure_monitors")]
public class BloodPressureMonitor
{
    /// <summary>
    /// Relevant Patient Id used as key
    /// </summary>
    [Key]
    [Column("id", TypeName = "nvarchar"), StringLength(450)]
    public required string Id { get; set; }

    [Column("is_omron_monitor")]
    public bool IsOmronMonitor { get; set; } = true;
    [Column("omron_number")]
    public int? OmronNumber { get; set; }

    [Column("modified_at")]
    public required DateTime ModifiedAt { get; set; } = DateTime.Now;
    [Column("created_at")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
}

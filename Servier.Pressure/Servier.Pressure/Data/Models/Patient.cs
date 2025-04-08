using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Servier.Pressure.Data.Models;

[Table("patients")]
public class Patient
{
    public enum ValidEnum
    {
        Aktívny,
        Predčasne_vylúčený
    }

    [Key]
    [Column("id", TypeName = "nvarchar"), StringLength(450)]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    /// <summary>
    /// User id -> "AspNetUser"
    /// </summary>
    [Column("id_user", TypeName = "nvarchar"), StringLength(450)]
    public required string UserId { get; set; }

    [Column("valid")]
    public ValidEnum Valid { get; set; } = ValidEnum.Aktívny;

    /// <summary>
    ///  Patient code
    /// </summary>
    [Column("patient_code", TypeName = "varchar"), StringLength(10)]
    public required string PatientCode { get; set; }

    [Column("patient", TypeName = "nvarchar"), StringLength(255)]
    public string? PatientName { get; set; }

    [Column("modified_at")]
    public required DateTime ModifiedAt { get; set; } = DateTime.Now;

    [Column("created_at")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;

    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }

    [NotMapped]
    public string? Doctor { get; set; }

}

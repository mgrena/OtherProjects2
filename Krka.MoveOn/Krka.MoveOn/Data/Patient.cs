using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Krka.MoveOn.Data
{
    [Table("patients")]
    public class Patient
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// User id -> "AspNetUser"
        /// </summary>
        [Column("id_user", TypeName ="nvarchar"), StringLength(450)]
        public required string UserId { get; set; }

        [Column("info_confirm")]
        public bool InfoConfirmation { get; set; } = false;

        [Column("gdpr_confirm")]
        public bool GDPRConfirmation { get; set; } = false;

        /// <summary>
        ///  Patient code   
        /// </summary>
        [Column("patient_code", TypeName = "varchar"), StringLength(10)]
        public required string PatientCode { get; set; }

        [Column("modified_at")]
        public required DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("created_at")]
        public required DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; }

        [NotMapped]
        public string? Doctor { get; set; }

    }
}

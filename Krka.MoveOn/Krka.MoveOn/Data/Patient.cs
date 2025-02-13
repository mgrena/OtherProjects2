using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Krka.MoveOn.Data
{
    [Table("patients")]
    public class Patient
    {
        public enum ValidEnum
        {
            Aktivný,
            Predčasne_vylúčený
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// User id -> "AspNetUser"
        /// </summary>
        [Column("id_user", TypeName = "nvarchar"), StringLength(450)]
        public required string UserId { get; set; }

        [Column("info_confirm")]
        public bool InfoConfirmation { get; set; } = false;

        [Column("gdpr_confirm")]
        public bool GDPRConfirmation { get; set; } = false;

        [Column("valid")]
        public ValidEnum Valid { get; set; } = ValidEnum.Aktivný;

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

        [Range(0, 100)]
        [Column("entry_progress_percentage", TypeName = "int")]
        public int EntryProgressPercentage { get; set; } = 0;

        [Range(0, 100)]
        [Column("ongoing_progress_percentage", TypeName = "int")]
        public int OngoingProgressPercentage { get; set; } = 0;

        [Range(0, 100)]
        [Column("result_progress_percentage", TypeName = "int")]
        public int ResultProgressPercentage { get; set; } = 0;


    }
}

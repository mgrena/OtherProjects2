using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Krka.MoveOn.Data.Questionnaires
{
    [Table("questionnaires")]
    public class Questionnaire
    {

        public enum QuestionnaireOrderEnum
        {
            entry = 1,
            ongoing = 2,
            result = 3
        }

        [Key]
        [Column("id", TypeName = "nvarchar"), StringLength(450)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Column("id_patient")]
        public required int PatientId { get; set; }

        [Column("questionnaire_date")]
        public required DateTime Date { get; set; }

        [Column("order_num")]
        public required QuestionnaireOrderEnum Order { get; set; }

        [Range(0, 100)]
        [Column("progress_percentage", TypeName = "int")]
        public int ProgressPercentage { get; set; } = 0;

        [Column("modified_at")]
        public required DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("created_at")]
        public required DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

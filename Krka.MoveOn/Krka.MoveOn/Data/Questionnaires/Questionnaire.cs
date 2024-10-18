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
        [Column("id")]
        public int Id { get; set; }

        [Column("id_patient")]
        public required int PatientId { get; set; }

        [Column("questionnaire_date")]
        public required DateTime Date { get; set; }

        [Column("order_num")]
        public required QuestionnaireOrderEnum Order { get; set; }
       
        [Column("modified_at")]
        public required DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("created_at")]
        public required DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

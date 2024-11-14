using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Krka.MoveOn.Data.Questionnaires
{
    [Table("questionnaire_drug_effect09")]
    public class QuestionnaireDrugEffect09
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("questionnaire_id", TypeName = "nvarchar"), StringLength(450)]
        public required string Questionnaire_id { get; set; }

        /// <summary>
        /// Nežiaduci účinok liečiva: => DialDrugEffect - ciselnik
        /// </summary>
        [Column("de_1")]
        public int? De_1 {  get; set; }

        /// <summary>
        /// liek - DialDrugEffect - ciselnik
        /// </summary>
        [Column("de_2")]
        public int? De_2 { get; set; }

        /// <summary>
        /// dávka mg/deň
        /// </summary>
        [Column("de_3", TypeName = "decimal(5,2)")]
        public decimal? De_3 { get; set; }

        /// <summary>
        /// nežiaduci účinok - DialDrugEffect - ciselnik
        /// </summary>
        [Column("de_4")]
        public int? De_4 { get; set; }

        /// <summary>
        /// indikácia - DialDrugEffect - ciselnik
        /// </summary>
        [Column("de_5")]
        public int? De_5 { get; set; }

        [Column("modified_at")]
        public required DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("created_at")]
        public required DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; }
    }
}

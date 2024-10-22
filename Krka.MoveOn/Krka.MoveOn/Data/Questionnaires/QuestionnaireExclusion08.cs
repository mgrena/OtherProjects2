using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Krka.MoveOn.Data.Questionnaires
{
    [Table("questionnaire_exclusion08")]
    public class QuestionnaireExclusion08
    {
        [Key]
        [Column("id")]
        public  int Id { get; set; }

        [Column("questionnaire_id")]
        public required int Questionnaire_id { get; set; }

        /// <summary>
        /// Ukončuje subjekt účasť v štúdii?  - DialQGeneral - ciselnik s odpovedou
        /// </summary>
        [Column("exc_q")]
        public int? Exc_Q { get; set; }

        /// <summary>
        /// Dátum predčasného vylúčenia : _ _ /_ _ /_ _ _ _ (deň/mesiac/rok, kalendár) 
        /// </summary>
        [Column("exc_1")]
        public DateTime? Exc_1 { get; set; }

        /// <summary>
        /// Ako ste zbierali údaje o pacientoch? Číselník (Exclusion)
        /// </summary>
        [Column("exc_2")]
        public int? Exc_2 { get; set; }

        /// <summary>
        /// Aký je dôvod, prečo bol pacient predčasne vylúčený z tejto štúdie?  Číselník (Exclusion)
        /// </summary>
        [Column("exc_3")]
        public int? Exc_3 { get; set; }

        [Column("modified_at")]
        public DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}

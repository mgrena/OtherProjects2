using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Krka.MoveOn.Data.Questionnaires
{
    [Table("questionnaire_exclusion08")]
    public class QuestionnaireExclusion08
    {
        [Key]
        [Column("id")]
        public required int Id { get; set; }

        [Column("id_patient")]
        public required int PatientId { get; set; }

        /// <summary>
        /// Ukončuje subjekt účasť v štúdii?  - DialQGeneral - ciselnik s odpovedou
        /// </summary>
        [Column("exc_q")]
        public int? Exc_Q { get; set; }

        /// <summary>
        /// Dátum predčasného vylúčenia : _ _ /_ _ /_ _ _ _ (deň/mesiac/rok, kalendár) 
        /// </summary>
        [Column("exc_1")]
        public required DateTime Exc_1 { get; set; }

        /// <summary>
        /// Ako ste zbierali údaje o pacientoch? Číselník (Exclusion)
        /// </summary>
        [Column("exc_2")]
        public required int Exc_2 { get; set; }

        /// <summary>
        /// Aký je dôvod, prečo bol pacient predčasne vylúčený z tejto štúdie?  Číselník (Exclusion)
        /// </summary>
        [Column("exc_3")]
        public int? Exc_3 { get; set; }

        [Column("modified_at")]
        public required DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("created_at")]
        public required DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}

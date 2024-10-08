using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Krka.MoveOn.Data.Questionnaires
{
    [Table("questionnaire_moca07")]
    public class QuestionnaireMoca07
    {
        [Key]
        [Column("id")]
        public required int Id { get; set; }

        [Column("id_patient")]
        public required int PatientId { get; set; }

        /// <summary>
        /// Vizuálno-priestorové schopnosti - "Test cesty"
        /// </summary>
        [Column("moca_1")]
        public required int Moca_1 { get; set; }

        /// <summary>
        /// Vizuálno-priestorové schopnosti - "Kocka"
        /// </summary>
        [Column("moca_2")]
        public required int Moca_2 { get; set; }

        /// <summary>
        /// Vizuálno-priestorové schopnosti - "Hodiny "
        /// </summary>
        [Column("moca_3")]
        public required int Moca_3 { get; set; }

        /// <summary>
        /// Pomenovanie zvierat
        /// </summary>
        [Column("moca_4")]
        public required int Moca_4 { get; set; }

        /// <summary>
        /// Pozornosť - Vymenovanie čísel 
        /// </summary>
        [Column("moca_5")]
        public required int Moca_5 { get; set; }

        /// <summary>
        /// Pozornosť - Identifikácia písmena  
        /// </summary>
        [Column("moca_6")]
        public required int Moca_6 { get; set; }

        /// <summary>
        /// Pozornosť - Odpočítavanie  
        /// </summary>
        [Column("moca_7")]
        public required int Moca_7 { get; set; }

        /// <summary>
        /// Jazyk - Opakovanie vety  
        /// </summary>
        [Column("moca_8")]
        public required int Moca_8 { get; set; }

        /// <summary>
        /// Jazyk - Verbálna fluencia 
        /// </summary>
        [Column("moca_9")]
        public required int Moca_9 { get; set; }

        /// <summary>
        /// Abstrakcia
        /// </summary>
        [Column("moca_10")]
        public required int Moca_10 { get; set; }

        /// <summary>
        /// Vybavovanie slov 
        /// </summary>
        [Column("moca_11")]
        public required int Moca_11 { get; set; }

        /// <summary>
        /// Orientacia 
        /// </summary>
        [Column("moca_12")]
        public required int Moca_12 { get; set; }

        [Column("modified_at")]
        public required DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("created_at")]
        public required DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Krka.MoveOn.Data.Questionnaires
{

    [Table("questionnaire_treatment03")]
    public class QuestionnaireTreatment03
    {
        [Key]
        [Column("id")]
        public required int Id { get; set; }

        [Column("id_patient")]
        public required int PatientId { get; set; }

        /// <summary>
        /// Zmena v liečbe pridružených problémov (napr. obstipácia, depresia, kognitívne poruchy atď.) -> DialQGeneral- ciselnik odpovedmi
        /// </summary>
        [Column("treat_q_1")]
        public int? TreatQ1 { get; set; }

        /// <summary>
        /// liek - Ucinna latka - čísleník na DialActiveIngredient
        /// </summary>
        [Column("treat_1")]
        public int? Treat_1 { get; set; }

        /// <summary>
        /// Dávka (mg)
        /// </summary>
        [Column("treat_2", TypeName = "decimal(5,2)")]
        public decimal Treat_2 { get; set; }

        /// <summary>
        /// indikácia - čísleník na DialIndication
        /// </summary>
        [Column("treat_3")]
        public int? Treat_3 { get; set; }


        [Column("modified_at")]
        public required DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("created_at")]
        public required DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Krka.MoveOn.Data.Questionnaires
{
    [Table("questionnaire_satisfaction10")]
    public class QuestionnaireSatisfaction10
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("questionnaire_id", TypeName = "nvarchar"), StringLength(450)]
        public required string Questionnaire_id { get; set; }

        /// <summary>
        /// Celková spokojnosť s liečbou
        /// </summary>
        [Column("sf_1")]
        public required int SF_1 { get; set; }

        /// <summary>
        /// Spokojnosť so zlepšením depresívnych symptómov
        /// </summary>
        [Column("sf_2")]
        public required int SF_2 { get; set; }

        /// <summary>
        /// Spokojnosť so zlepšením ranných príznakov (t.j. ranná stuhnutosť, problém so vstávaním z postele)
        /// </summary>
        [Column("sf_3")]
        public required int SF_3 { get; set; }

        /// <summary>
        /// Spokojnosť so zlepšením únavy
        /// </summary>
        [Column("sf_4")]
        public required int SF_4 { get; set; }

        [Range(0, 100)]
        [Column("progress_percentage", TypeName = "int")]
        public int ProgressPercentage { get; set; } = 0;

        [Column("modified_at")]
        public DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

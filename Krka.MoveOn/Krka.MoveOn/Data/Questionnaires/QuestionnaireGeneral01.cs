using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Krka.MoveOn.Data.Questionnaires
{
    [Table("questionnaire_general01")]
    public class QuestionnaireGeneral01
    {
       
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("questionnaire_id", TypeName = "nvarchar"), StringLength(450)]
        public required string Questionnaire_id { get; set; }
        /// <summary>
        /// Dátum (DD/MM/RRRR) 
        /// </summary>
        [Column("gen_1")]
        public DateTime Gen_1 { get; set; } = DateTime.Now;

        /// <summary>
        /// Pohlavie
        /// </summary>
        [Column("gen_2_dg")]
        public int Gen_2_DG { get; set; }

        /// <summary>
        /// Rodinný stav
        /// </summary>
        [Column("gen_3_dg")]
        public int Gen_3_DG { get; set; }

        /// <summary>
        /// Pracovný pomer 
        /// </summary>
        [Column("gen_4_dg")]
        public int Gen_4_DG { get; set; }

        /// <summary>
        /// Fajčenie
        /// </summary>
        [Column("gen_5_dg")]
        public int Gen_5_D { get; set; }

        /// <summary>
        /// Pozitívna rodinná anamnéza Parkinsonovej choroby 
        /// </summary>
        [Column("gen_6_dg")]
        public int Gen_6_DG { get; set; }

        /// <summary>
        /// Anamnéza užívania antipsychotík 
        /// </summary>
        [Column("gen_7_dg")]
        public int Gen_7_DG { get; set; }

        /// <summary>
        /// Dĺžka trvania ťažkostí (v mesiacoch)
        /// </summary>
        [Column("gen_8")]
        public int Gen_8 { get; set; }

        /// <summary>
        /// Bol pacient už kvôli tomuto príznaku vyšetrený .ortopédom, psychiatrom a pod.?
        /// </summary>
        [Column("gen_10")]
        public int Gen_10 { get; set; }

        /// <summary>
        /// 10.1 - Ak áno, ktorá špecializácia?   
        /// </summary>
 
        [Column("gen_10_1")]
        public int? Gen_10_1 { get; set; }

        /// <summary>
        /// 10.1 -Ak da moznost "Ine" (pise Specializaciu)
        /// </summary>
        [Column("gen_10_1_1", TypeName = "varchar"), StringLength(60)]
        public string? Gen_10_1_1 { get; set; }

        /// <summary>
        /// Stal sa pacientovi pred objavením príznaku úraz hlavy? 
        /// </summary>
        [Column("gen_11")]
        public int Gen_11 { get; set; }

        /// <summary>
        /// Celková anestézia pred objavením sa príznaku? 
        /// </summary>
        [Column("gen_12")]
        public int Gen_12 { get; set; }

        /// <summary>
        /// Pacientovi je diagnostikované/je podozrenie na
        /// </summary>
        [Column("gen_13")]
        public int Gen_13 { get; set; }

        /// <summary>
        /// Pacientovi je diagnostikované/je podozrenie na (Ak zada "Iný parkinsonský syndróm ")
        /// </summary>
        [Column("gen_13_1", TypeName = "nvarchar"), StringLength(30)]
        public string? Gen_13_1 { get; set; }


        [Range(0, 100)]
        [Column("progress_percentage", TypeName = "int")]
        public int ProgressPercentage { get; set; } = 0;


        [Column("modified_at")]
        public  DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("created_at")]
        public  DateTime CreatedAt { get; set; } = DateTime.Now;


    }
}

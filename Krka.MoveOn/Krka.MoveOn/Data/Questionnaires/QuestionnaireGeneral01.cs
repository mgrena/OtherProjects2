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

        [Column("questionnaire_id")]
        public required int Questionnaire_id { get; set; }
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
        ///   -Ak áno názov mediciny (číselnik na DialMedicines) !!!!!!!!!!
        /// </summary>
        [Column("gen_7_1_dm")]
        public int Gen_7_1_DM { get; set; }

        /// <summary>
        ///  - Davka 
        /// </summary>
        [Column("gen_7_2", TypeName = "decimal(5,2)")]
        public decimal Gen_7_2 { get; set; }

        /// <summary>
        /// - jednotka (číselnýk na DialUnits) !!!!!!!!! 
        /// </summary>
        [Column("gen_7_3_du")]
        public int Gen_7_3_DU { get; set; }


        /// <summary>
        /// - Dĺžka užívania v rokoch 
        /// </summary>
        [Column("gen_7_4", TypeName = "decimal(3,1)")]
        public decimal Gen_7_4 { get; set; }

        /// <summary>
        /// Ak na Otazku 7 dá odpoveď ine (Názov Mediciny)
        /// </summary>
        [Column("gen_7_1_1", TypeName = "varchar"), StringLength(20)]
        public string? Gen_7_1_1 { get; set; }

        /// <summary>
        /// Ak na Otazku 7 dá odpoveď ine (Davka)
        /// </summary>
        [Column("gen_7_1_2", TypeName = "decimal(5,2)")]
        public decimal Gen_7_1_2 { get; set; }

        /// <summary>
        /// Ak na Otazku 7 dá odpoveď ine - jednotka (číselnýk na DialUnits) !!!!!!!!!!!!!
        /// </summary>
        [Column("gen_7_1_3_du")]
        public int? Gen_7_1_3_DU { get; set; }

        /// <summary>
        ///  Ak na Otazku 7 dá odpoveď ine - ( Dĺžka užívania v rokoch )
        /// </summary>
        [Column("gen_7_1_4", TypeName = "decimal(3,1)")]
        public decimal Gen_7_1_4 { get; set; }

        /// <summary>
        /// Dĺžka trvania ťažkostí (v mesiacoch)
        /// </summary>
        [Column("gen_8")]
        public int Gen_8 { get; set; }

        /// <summary>
        /// Prvý príznak Parkinsonovej choroby (číselnik na DialSymptoms) !!!!!!!! 
        /// </summary>
        [Column("gen_9_ds")]
        public int Gen_9_DS { get; set; }

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


        [Column("modified_at")]
        public  DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("created_at")]
        public  DateTime CreatedAt { get; set; } = DateTime.Now;


    }
}

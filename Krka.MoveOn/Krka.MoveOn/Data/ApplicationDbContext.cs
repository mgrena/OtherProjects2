using Krka.MoveOn.Data.AdverseEffects;
using Krka.MoveOn.Data.Dials;
using Krka.MoveOn.Data.Questionnaires;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Data; 
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options) 
{

    /// <summary>
    /// List of log entries
    /// </summary>
    public DbSet<LogEntity> Logs { get; set; } = null!;

    /// <summary>
    /// Data
    /// </summary>
    public DbSet<Patient> Patients { get; set; }

    /// <summary>
    /// Adverse effects
    /// </summary>
    public DbSet<AdverseEffect> AdverseEffects { get; set; }

    /// <summary>
    /// Questionnaires
    /// </summary>

    public DbSet<Questionnaire> Questionnaires { get; set; }
    public DbSet<QuestionnaireGeneral01> QuestionnaireGeneral01s { get; set; }

    public DbSet<QuestionnaireInitial02> QuestionnaireInitial02s { get; set; }

    public DbSet<QuestionnaireTreatment03> QuestionnaireTreatment03s { get; set; }

    public DbSet<QuestionnaireNonMotor04> QuestionnaireNonMotor04s { get; set; }

    public DbSet<QuestionnaireMotor05> QuestionnaireMotor05s { get; set; }

    public DbSet<QuestionnaireMotorSkill06> QuestionnaireMotorSkill06s { get; set; }

    public DbSet<QuestionnaireMoca07> QuestionnaireMoca07s { get; set; }

    public DbSet<QuestionnaireExclusion08> QuestionnaireExclusion08s { get; set; }

    public DbSet<QuestionnaireDrugEffect09> QuestionnaireDrugEffect09s { get; set; }

    public DbSet<QuestionnaireSatisfaction10> QuestionnaireSatisfaction10s { get; set; }

    /// <summary>
    /// Dials
    /// </summary>
    public DbSet<DialActiveIngredient> DialActiveIngredients { get; set; }

    public DbSet<DialAdverseEffect> DialAdverseEffects { get; set; }

    public DbSet<DialExclusion> DialExclusions { get; set; }

    public DbSet<DialIndication> DialIndication { get; set; }

    public DbSet<DialMedicine> DialMedicines { get; set; }

    public DbSet<DialMH> DialMHs { get; set; }

    public DbSet<DialQGeneral> DialQGenerals { get; set; }

    public DbSet<DialSpecialization> DialSpecializations { get; set; }

    public DbSet<DialSymptoms> DialSymptomses { get; set; }

    public DbSet<DialUnit> DialUnits { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<LogEntity>(entity =>
        {
            entity.Property(e => e.Message).HasColumnType("nvarchar(max)");
        });

        // seed data

        // Dial General Questionnaire
        #region "DialQGenerals_Answers"
            //gen_2_DG
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 1, Type_q = 1, Name = "Muû", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 2, Type_q = 1, Name = "éena", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            //gen_3_DG
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 3, Type_q = 2, Name = "Slobodn˝/·", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 4, Type_q = 2, Name = "éenat˝/Vydat·", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 5, Type_q = 2, Name = "Vdovec/Vdova", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 6, Type_q = 2, Name = "Rozveden˝/·", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            //gen_4_DG
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 7, Type_q = 3, Name = "Zamestnan˝/·", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 8, Type_q = 3, Name = "Nezamestnan˝/·", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 9, Type_q = 3, Name = "Starobn˝ dÙchodok", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 10, Type_q = 3, Name = "Invalidn˝ dÙchodok", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            //gen_5_D
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 11, Type_q = 4, Name = "¡no", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 12, Type_q = 4, Name = "Ex-fajËiar", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 13, Type_q = 4, Name = "Nie", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            //gen_6_DG
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 14, Type_q = 5, Name = "¡no", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 15, Type_q = 5, Name = "Nie", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            //gen_7_DG
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 16, Type_q = 6, Name = "¡no", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 17, Type_q = 6, Name = "Nie", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            //gen_7_1DM
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 18, Type_q = 7, Name = "KvetiapÌn", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 19, Type_q = 7, Name = "KlozapÌn", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 20, Type_q = 7, Name = "OlanzapÌn", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 21, Type_q = 7, Name = "Risperidon", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 22, Type_q = 7, Name = "Paliperidon", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 23, Type_q = 7, Name = "Tiapridal", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 24, Type_q = 7, Name = "Haloperidol", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 25, Type_q = 7, Name = "Chloprprotixen", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 26, Type_q = 7, Name = "Lurasidon", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 27, Type_q = 7, Name = "Aripiprazol", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 28, Type_q = 7, Name = "Levomepromazin", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 29, Type_q = 7, Name = "Flupentixol", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 30, Type_q = 7, Name = "Zuklopentixol", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 31, Type_q = 7, Name = "Sulpirid", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 32, Type_q = 7, Name = "Amilsulprid", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 33, Type_q = 7, Name = "Ziprasidon", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 34, Type_q = 7, Name = "InÈ...", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            
    
            //gen_7_3_DU
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 35, Type_q = 8, Name = "mg", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });

            //gen_9_Ds
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 36, Type_q = 9, Name = "Porucha Ëuchu", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 37, Type_q = 9, Name = "Porucha spr·vania v†REM sp·nku", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 38, Type_q = 9, Name = "Depresia alebo ˙zkosù", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 39, Type_q = 9, Name = "Dlhotrvaj˙ca z·pcha", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 40, Type_q = 9, Name = "Bolesti ramena", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 41, Type_q = 9, Name = "Predklonen˝ postoj", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 42, Type_q = 9, Name = "SpomalenÈ pohyby/chÙdza", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 43, Type_q = 9, Name = "Tras", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 44, Type_q = 9, Name = "Oslaben· mimika v†tv·ri (hypomÌmia)", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 45, Type_q = 9, Name = "Vytekanie slÌn z ˙st", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 46, Type_q = 9, Name = "ProblÈmy s†rann˝m vst·vanÌm z†postele", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 47, Type_q = 9, Name = "OpakovanÈ p·dy", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });

            //gen_10
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 48, Type_q = 10, Name = "Praktick˝ lek·r", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 49, Type_q = 10, Name = "OrtopÈd", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 50, Type_q = 10, Name = "NeurolÛg", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 51, Type_q = 10, Name = "Psychiater", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 52, Type_q = 10, Name = "Fyzioterapeut", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 53, Type_q = 10, Name = "Internista", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });

            //gen_13
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 54, Type_q = 11, Name = "Idiopatick· PCH", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 55, Type_q = 11, Name = "In˝ parkinsonsk˝ syndrÛm ", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
            modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 56, Type_q = 11, Name = "NiË z vyööie uvedenÈho ", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        #endregion

        #region "DialActiveIngredient"
            //init_1
            modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 1, Type_q = 1, Name = "Levodopa/Karbidopa", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 2, Type_q = 1, Name = "Levodopa/Benserazid", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 3, Type_q = 1, Name = "Entakapon", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 4, Type_q = 1, Name = "Tolkapon", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 5, Type_q = 1, Name = "Opikapon", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 6, Type_q = 1, Name = "RasagilÌn", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 7, Type_q = 1, Name = "Pramipexol", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 8, Type_q = 1, Name = "Ropinirol", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 9, Type_q = 1, Name = "RotigotÌn", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 10, Type_q = 1, Name = "ApomorfÌn", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 11, Type_q = 1, Name = "AmantadÌn", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });

        #endregion

        #region "DialIndication"
        //treat_3
            modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 1, Type_q = 1, Name = "Pruhy moËenia", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 2, Type_q = 1, Name = "Erektiln· dysfunkcia", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 3, Type_q = 1, Name = "Z·pcha", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 4, Type_q = 1, Name = "Porucha sp·nku", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 5, Type_q = 1, Name = "Ortostatick· hypotenzia", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 6, Type_q = 1, Name = "Depresia", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 7, Type_q = 1, Name = "⁄zkosù", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 8, Type_q = 1, Name = "PsychÛza (halucin·cie, bludy)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 9, Type_q = 1, Name = "InÈ...", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        #endregion

        #region "DialMH"
            modelBuilder.Entity<DialMH>().HasData(new DialMH() { Id = 1, Type_q = 1, Number = "1", Name = "JednostrannÈ prÌznaky", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialMH>().HasData(new DialMH() { Id = 2, Type_q = 1, Number = "1,5", Name = "JednostrannÈ a axi·lne prÌznaky (hypofÛnia, hypomÌmia, flekËnÈdrûanie tela)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialMH>().HasData(new DialMH() { Id = 3, Type_q = 1, Number = "2", Name = "ObojstrannÈ prÌznaky bez poruchy rovnov·hy", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialMH>().HasData(new DialMH() { Id = 4, Type_q = 1, Number = "2,5", Name = "ObojstrannÈ prÌznaky s miernou poruchou rovnov·hy (schopnosù vyrovnaù postoj pri pull teste)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialMH>().HasData(new DialMH() { Id = 5, Type_q = 1, Number = "3", Name = "Mierne aû strednÈ obojstrannÈ prÌznaky, postur·lnainstabilita, pacient je st·le sebestaËn˝", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialMH>().HasData(new DialMH() { Id = 6, Type_q = 1, Number = "4", Name = "çaûkÈ postihnutie, no pacient je schopn˝ chodiù alebo st·ù bez pomoci", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialMH>().HasData(new DialMH() { Id = 7, Type_q = 1, Number = "5", Name = "Pacient je odk·zan˝ na vozÌk alebo posteæ", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        #endregion

        #region "Dial Exclusion"
        //exc_2
            modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 1, Type_q = 1, Name = "Pri n·vöteve pacienta na mieste", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 2, Type_q = 1, Name = "Na diaæku prostrednÌctvom telefonickÈho hovoru", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 3, Type_q = 1, Name = "Na diaæku prostrednÌctvom elektronick˝ch mÈdiÌ", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        //exc_3
            modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 4, Type_q = 2, Name = "V˝skyt z·vaûnej neûiaducej reakcie poËas pozorovacieho obdobia v tejto öt˙dii", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 5, Type_q = 2, Name = "Smrù", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 6, Type_q = 2, Name = "Hospitaliz·cia", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 7, Type_q = 2, Name = "Rozhodnutie pacienta ukonËiù lieËbu a odvolanie jeho informovanÈho s˙hlasu", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 8, Type_q = 2, Name = "Rozhodnutie pacienta ukonËiù lieËbu a odvolanie informovanÈho s˙hlasu a GDPR formul·ra", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 9, Type_q = 2, Name = "BezpeËnosù pacienta (napr. rozhodnutie sk˙öaj˙ceho vyl˙Ëiù pacienta zo öt˙die v jeho najlepöom z·ujme, neûiaduce ˙Ëinky vyûaduj˙ce medikamentÛzny z·sah alebo ukonËenie lieËby)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 10, Type_q = 2, Name = "O alebo zhoröenie existuj˙ceho ochorenia poËas öt˙die, ktorÈ si vyûaduje pouûÌvanie liekov, ktorÈ nie s˙ povolenÈ v spojenÌ so s˙hrnom charakteristick˝ch vlastnostÌ lieku pouûit˝ch liekov", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 11, Type_q = 2, Name = "InÈ...", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        #endregion

        #region "Dial AdverseEffect"
        //Frekvencia
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 1, Type_q = 1, Name = "Jedenkr·t", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 2, Type_q = 1, Name = "ObËas", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 3, Type_q = 1, Name = "Neust·le", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        //S˙vis 
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 4, Type_q = 2, Name = "Nes˙visÌ (Ak je NU klasifikovan· ako nes˙visiaca s liekom)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 5, Type_q = 2, Name = "Nepravdepodobne s˙visÌ (udalosù s najv‰Ëöou pravdepodobnosùou nebola spÙsoben· liekom, ale prÌËinn˙ s˙vislosù nemoûno ˙plne vyl˙Ëiù)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 6, Type_q = 2, Name = "Moûno s˙visÌ (Udalosù mÙûe, ale nemusÌ byù spÙsoben· liekom, prÌËinn˙ s˙vislosù nie je moûnÈ pos˙diù s v‰Ëöou istotou)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 7, Type_q = 2, Name = "Pravdepodobne s˙visÌ (Liek je najpravdepodobnejöou prÌËinou udalosti, ale nemoûno vyl˙Ëiù inÈ prÌËiny)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 8, Type_q = 2, Name = "Takmer urËite s˙visÌ (Liek je takmer urËite prÌËinou udalosti, neexistuj˙ ûiadne inÈ zjavnÈ alternatÌvne vysvetlenia)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        //Zavaznost
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 9, Type_q = 3, Name = "Nez·vaûnÈ", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 10, Type_q = 3, Name = "éivot ohrozuj˙ce", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 11, Type_q = 3, Name = "Hospitaliz·cia (zaËat· alebo predÂûen·)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 12, Type_q = 3, Name = "ZdravotnÈ postihnutie", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 13, Type_q = 3, Name = "Vroden· anom·lia", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 14, Type_q = 3, Name = "Smrù", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 15, Type_q = 3, Name = "Z·vaûnÈ podæa n·zoru sk˙öaj˙ceho lek·ra", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        //Intenzita
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 16, Type_q = 4, Name = "Mierna (NespÙsobuje obmedzenie beûn˝ch ËinnostÌ, pacient mÙûe pociùovaù mierne nepohodlie)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 17, Type_q = 4, Name = "Stredne ùaûk· (SpÙsobuje urËitÈ obmedzenia beûn˝ch aktivÌt, pacient mÙûe pociùovaù neprÌjemnÈ nepohodlie)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 18, Type_q = 4, Name = "çaûk· (SpÙsobuje neschopnosù vykon·vaù beûnÈ Ëinnosti, pacient mÙûe pociùovaù neznesiteænÈ nepohodlie alebo bolesù)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        //Vplyv na lieËbu
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 19, Type_q = 5, Name = "Bez n·sledkov", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 20, Type_q = 5, Name = "Zmeny v lieËbe", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 21, Type_q = 5, Name = "ZnÌûenie d·vky", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 22, Type_q = 5, Name = "Symptomatick· lieËba", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 23, Type_q = 5, Name = "Hospitaliz·cia", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        //Vysledok
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 24, Type_q = 6, Name = "Prestala", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
            modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 25, Type_q = 6, Name = "PokraËuje", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });

        #endregion

    }
}
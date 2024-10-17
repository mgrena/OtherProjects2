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

    }
}
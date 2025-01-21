using Krka.MoveOn.Data.AdverseEffects;
using Krka.MoveOn.Data.Dials;
using Krka.MoveOn.Data.Questionnaires;
using Krka.MoveOn.Data.RelationalTables;
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

    /// <summary>
    /// Relation Tables
    /// </summary>
    public DbSet<Gen9DSRelational> Gen9DSRelationals { get; set; }
    public DbSet<Gen7YesRelational> Gen7YesRelationals { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    base.OnConfiguring(optionsBuilder);
    //    optionsBuilder.EnableSensitiveDataLogging();
    //}
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
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 1, Type_q = 1, Name = "Muž", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 2, Type_q = 1, Name = "Žena", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        //gen_3_DG
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 3, Type_q = 2, Name = "Slobodný/á", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 4, Type_q = 2, Name = "Ženatý/Vydatá", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 5, Type_q = 2, Name = "Vdovec/Vdova", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 6, Type_q = 2, Name = "Rozvedený/á", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        //gen_4_DG
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 7, Type_q = 3, Name = "Zamestnaný/á", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 8, Type_q = 3, Name = "Nezamestnaný/á", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 9, Type_q = 3, Name = "Starobný dôchodok", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 10, Type_q = 3, Name = "Invalidný dôchodok", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        //gen_5_D
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 11, Type_q = 4, Name = "Áno", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 12, Type_q = 4, Name = "Ex-fajčiar", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 13, Type_q = 4, Name = "Nie", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        //gen_6_DG
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 14, Type_q = 5, Name = "Áno", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 15, Type_q = 5, Name = "Nie", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        //gen_7_DG
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 16, Type_q = 6, Name = "Áno", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 17, Type_q = 6, Name = "Nie", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        //gen_7_1DM
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 18, Type_q = 7, Name = "Kvetiapín", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 19, Type_q = 7, Name = "Klozapín", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 20, Type_q = 7, Name = "Olanzapín", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 21, Type_q = 7, Name = "Risperidon", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 22, Type_q = 7, Name = "Paliperidon", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 23, Type_q = 7, Name = "Tiapridal", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 24, Type_q = 7, Name = "Haloperidol", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 25, Type_q = 7, Name = "Chlorprotixen", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 26, Type_q = 7, Name = "Lurasidon", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 27, Type_q = 7, Name = "Aripiprazol", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 28, Type_q = 7, Name = "Levomepromazin", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 29, Type_q = 7, Name = "Flupentixol", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 30, Type_q = 7, Name = "Zuklopentixol", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 31, Type_q = 7, Name = "Sulpirid", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 32, Type_q = 7, Name = "Amilsulprid", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 33, Type_q = 7, Name = "Ziprasidon", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 34, Type_q = 7, Name = "Iné...", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        //gen_7_3_DU
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 35, Type_q = 8, Name = "mg", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        //gen_9_Ds
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 36, Type_q = 9, Name = "Porucha čuchu", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 37, Type_q = 9, Name = "Porucha správania v REM spánku", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 38, Type_q = 9, Name = "Depresia alebo úzkosť", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 39, Type_q = 9, Name = "Dlhotrvajúca zápcha", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 40, Type_q = 9, Name = "Bolesti ramena", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 41, Type_q = 9, Name = "Predklonený postoj", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 42, Type_q = 9, Name = "Spomalené pohyby/chôdza", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 43, Type_q = 9, Name = "Tras", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 44, Type_q = 9, Name = "Oslabená mimika v tvári (hypomímia)", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 45, Type_q = 9, Name = "Vytekanie slín z úst", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 46, Type_q = 9, Name = "Problémy s ranným vstávaním z postele", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 47, Type_q = 9, Name = "Opakované pády", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        //gen_10
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 48, Type_q = 10, Name = "Praktický lekár", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 49, Type_q = 10, Name = "Ortopéd", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 50, Type_q = 10, Name = "Neurológ", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 51, Type_q = 10, Name = "Psychiater", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 52, Type_q = 10, Name = "Fyzioterapeut", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 53, Type_q = 10, Name = "Internista", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 57, Type_q = 10, Name = "Iná...", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });

        //gen_13
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 54, Type_q = 11, Name = "Idiopatická PCH", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 55, Type_q = 11, Name = "Iný parkinsonský syndróm", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 56, Type_q = 11, Name = "Nič z vyššie uvedeného", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        #endregion

        #region "DialActiveIngredient"
        //init_1
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 1, Indication_id = null, Type_q = 1, Name = "Levodopa/Karbidopa", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 2, Indication_id = null, Type_q = 1, Name = "Levodopa/Benserazid", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 3, Indication_id = null, Type_q = 1, Name = "Entakapon", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 4, Indication_id = null, Type_q = 1, Name = "Tolkapon", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 5, Indication_id = null, Type_q = 1, Name = "Opikapon", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 6, Indication_id = null, Type_q = 1, Name = "Rasagilín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 7, Indication_id = null, Type_q = 1, Name = "Pramipexol", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 8, Indication_id = null, Type_q = 1, Name = "Ropinirol", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 9, Indication_id = null, Type_q = 1, Name = "Rotigotín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 10, Indication_id = null, Type_q = 1, Name = "Apomorfín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 11, Indication_id = null, Type_q = 1, Name = "Amantadín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });

        //news - Poruchy močenia
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 12, Indication_id = 1, Type_q = 2, Name = "Solifenacín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 13, Indication_id = 1, Type_q = 2, Name = "Mirabegron", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 14, Indication_id = 1, Type_q = 2, Name = "Trospium", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 15, Indication_id = 1, Type_q = 2, Name = "Avanafil", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 16, Indication_id = 1, Type_q = 2, Name = "Iné...", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });

        //news - Erektilná dysfunkcia
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 17, Indication_id = 2, Type_q = 2, Name = "Sildenafil", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 18, Indication_id = 2, Type_q = 2, Name = "Tadalafil", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 19, Indication_id = 2, Type_q = 2, Name = "Avanafil", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 20, Indication_id = 2, Type_q = 2, Name = "Iné...", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });

        //news - Zápcha
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 21, Indication_id = 3, Type_q = 2, Name = "Bisakodyl", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 22, Indication_id = 3, Type_q = 2, Name = "Laklulóza", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 23, Indication_id = 3, Type_q = 2, Name = "Makrogol", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 24, Indication_id = 3, Type_q = 2, Name = "Binatriumpikosulfát", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 25, Indication_id = 3, Type_q = 2, Name = "Prukaloprid", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 26, Indication_id = 3, Type_q = 2, Name = "Glycerol", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 27, Indication_id = 3, Type_q = 2, Name = "Iné...", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });

        //news - Porucha spánku
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 28, Indication_id = 4, Type_q = 2, Name = "Klonazepam", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 29, Indication_id = 4, Type_q = 2, Name = "Melatonín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 30, Indication_id = 4, Type_q = 2, Name = "Zopiklón", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 31, Indication_id = 4, Type_q = 2, Name = "Eszopiklón", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 32, Indication_id = 4, Type_q = 2, Name = "Zolpidem", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 33, Indication_id = 4, Type_q = 2, Name = "Cinalozepam", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 34, Indication_id = 4, Type_q = 2, Name = "Iné...", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });

        //news - Poruchy pamäti a kognície
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 35, Indication_id = 10, Type_q = 2, Name = "Donepezil", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 36, Indication_id = 10, Type_q = 2, Name = "Rivastigmín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 37, Indication_id = 10, Type_q = 2, Name = "Galantamín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 38, Indication_id = 10, Type_q = 2, Name = "Ginkgo biloba", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 39, Indication_id = 10, Type_q = 2, Name = "Memantín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 40, Indication_id = 10, Type_q = 2, Name = "Iné...", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });

        //news - Ortostatická hypotenzia
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 41, Indication_id = 5, Type_q = 2, Name = "Midodrin", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 42, Indication_id = 5, Type_q = 2, Name = "Fludrokortizón", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 43, Indication_id = 5, Type_q = 2, Name = "Iné...", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });

        //news - Depresia
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 44, Indication_id = 6, Type_q = 2, Name = "Agomelatín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 45, Indication_id = 6, Type_q = 2, Name = "Venlafaxín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 46, Indication_id = 6, Type_q = 2, Name = "Amitriptylín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 47, Indication_id = 6, Type_q = 2, Name = "Imipramín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 48, Indication_id = 6, Type_q = 2, Name = "Klomipramín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 49, Indication_id = 6, Type_q = 2, Name = "Paroxetín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 50, Indication_id = 6, Type_q = 2, Name = "Moklobemid", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 51, Indication_id = 6, Type_q = 2, Name = "Vortioxetín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 52, Indication_id = 6, Type_q = 2, Name = "Bupropion", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 53, Indication_id = 6, Type_q = 2, Name = "Citalopram", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 54, Indication_id = 6, Type_q = 2, Name = "Escitalopram", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 55, Indication_id = 6, Type_q = 2, Name = "Tianeptín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 56, Indication_id = 6, Type_q = 2, Name = "Duloxetín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 57, Indication_id = 6, Type_q = 2, Name = "Mirtazapín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 58, Indication_id = 6, Type_q = 2, Name = "Fluvoxamín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 59, Indication_id = 6, Type_q = 2, Name = "Fluoxetín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 60, Indication_id = 6, Type_q = 2, Name = "Mianserín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 61, Indication_id = 6, Type_q = 2, Name = "Lítium", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 62, Indication_id = 6, Type_q = 2, Name = "Sertralín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 63, Indication_id = 6, Type_q = 2, Name = "Trazodon", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 64, Indication_id = 6, Type_q = 2, Name = "Iné...", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });

        //news - Úzkosť
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 65, Indication_id = 7, Type_q = 2, Name = "Diazepam", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 66, Indication_id = 7, Type_q = 2, Name = "Hydroxyzín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 67, Indication_id = 7, Type_q = 2, Name = "Bromazepam", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 68, Indication_id = 7, Type_q = 2, Name = "Buspirón", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 69, Indication_id = 7, Type_q = 2, Name = "Alprazolam", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 70, Indication_id = 7, Type_q = 2, Name = "Chlórdiazepoxid", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 71, Indication_id = 7, Type_q = 2, Name = "Tofizopam", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 72, Indication_id = 7, Type_q = 2, Name = "Iné...", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });

        //news - Psychóza (halucinácie, bludy)
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 73, Indication_id = 8, Type_q = 2, Name = "Aripiprazol", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 74, Indication_id = 8, Type_q = 2, Name = "Amilsulprid", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 75, Indication_id = 8, Type_q = 2, Name = "Sulpirid", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 76, Indication_id = 8, Type_q = 2, Name = "Olanzapín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 77, Indication_id = 8, Type_q = 2, Name = "Zuklopentixol", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 78, Indication_id = 8, Type_q = 2, Name = "Klozapín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 79, Indication_id = 8, Type_q = 2, Name = "Kvetiapín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 80, Indication_id = 8, Type_q = 2, Name = "Palliperidón", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 81, Indication_id = 8, Type_q = 2, Name = "Tiapridal", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 82, Indication_id = 8, Type_q = 2, Name = "Haloperidol", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 83, Indication_id = 8, Type_q = 2, Name = "Lurazidón", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 84, Indication_id = 8, Type_q = 2, Name = "Lítium", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 85, Indication_id = 8, Type_q = 2, Name = "Kariprazín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 86, Indication_id = 8, Type_q = 2, Name = "Risperinón", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 87, Indication_id = 8, Type_q = 2, Name = "Sertindol", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 88, Indication_id = 8, Type_q = 2, Name = "Ziprasidón", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 89, Indication_id = 8, Type_q = 2, Name = "Zotepín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 90, Indication_id = 8, Type_q = 2, Name = "Iné...", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        #endregion

        #region "DialIndication"
        //treat_3
        modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 1, Type_q = 1, Name = "Poruchy močenia", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 2, Type_q = 1, Name = "Erektilná dysfunkcia", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 3, Type_q = 1, Name = "Zápcha", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 4, Type_q = 1, Name = "Porucha spánku", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 5, Type_q = 1, Name = "Ortostatická hypotenzia", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 6, Type_q = 1, Name = "Depresia", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 7, Type_q = 1, Name = "Úzkosť", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 8, Type_q = 1, Name = "Psychóza (halucinácie, bludy)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 9, Type_q = 1, Name = "Iné...", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 10, Type_q = 1, Name = "Poruchy pamäti a kognície", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        #endregion

        #region "DialMH"
        modelBuilder.Entity<DialMH>().HasData(new DialMH() { Id = 1, Type_q = 1, Number = "1", Name = "Jednostranné príznaky", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialMH>().HasData(new DialMH() { Id = 2, Type_q = 1, Number = "1,5", Name = "Jednostranné a axiálne príznaky (hypofónia, hypomímia, flekčné držanie tela) ", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialMH>().HasData(new DialMH() { Id = 3, Type_q = 1, Number = "2", Name = "Obojstranné príznaky bez poruchy rovnováhy", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialMH>().HasData(new DialMH() { Id = 4, Type_q = 1, Number = "2,5", Name = "Obojstranné príznaky s miernou poruchou rovnováhy (schopnosť vyrovnať postoj pri pull teste)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialMH>().HasData(new DialMH() { Id = 5, Type_q = 1, Number = "3", Name = "Mierne až stredné obojstranné príznaky, posturálna instabilita, pacient je stále sebestačný", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialMH>().HasData(new DialMH() { Id = 6, Type_q = 1, Number = "4", Name = "Ťažké postihnutie, no pacient je schopný chodiť alebo stáť bez pomoci", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialMH>().HasData(new DialMH() { Id = 7, Type_q = 1, Number = "5", Name = "Pacient je odkázaný na vozík alebo posteľ", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        #endregion

        #region "Dial Exclusion"
        //exc_2
        modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 1, Type_q = 1, Name = "Pri návšteve pacienta na mieste", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 2, Type_q = 1, Name = "Na diaľku prostredníctvom telefonického hovoru", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 3, Type_q = 1, Name = "Na diaľku prostredníctvom elektronických médií.", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        //exc_3
        modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 4, Type_q = 2, Name = "Výskyt závažnej nežiaducej reakcie počas pozorovacieho obdobia v tejto štúdii. *", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 5, Type_q = 2, Name = "Smrť *", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 6, Type_q = 2, Name = "Hospitalizácia *", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 7, Type_q = 2, Name = "Rozhodnutie pacienta ukončiť liečbu a odvolanie jeho informovaného súhlasu.", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 8, Type_q = 2, Name = "Rozhodnutie pacienta ukončiť liečbu a odvolanie informovaného súhlasu a GDPR formulára.", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 9, Type_q = 2, Name = "Bezpečnosť pacienta (napr. rozhodnutie skúšajúceho vylúčiť pacienta zo štúdie v jeho najlepšom záujme, nežiaduce účinky vyžadujúce medikamentózny zásah alebo ukončenie liečby). *", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 10, Type_q = 2, Name = "Aktuálne ochorenie alebo zhoršenie existujúceho ochorenia počas štúdie, ktoré si vyžaduje používanie liekov, ktoré nie sú povolené v spojení so súhrnom charakteristických vlastností lieku použitých liekov. *", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 11, Type_q = 2, Name = "Iné...", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        #endregion

        #region "Dial AdverseEffect"
        //Frekvencia
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 1, Type_q = 1, Name = "Jedenkrát", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 2, Type_q = 1, Name = "Občas", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 3, Type_q = 1, Name = "Neustále", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        //Súvis 
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 4, Type_q = 2, Name = "Nesúvisí (Ak je NU klasifikovaná ako nesúvisiaca s liekom)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 5, Type_q = 2, Name = "Nepravdepodobne súvisí (udalosť s najväčšou pravdepodobnosťou nebola spôsobená liekom, ale príčinnú súvislosť nemožno úplne vylúčiť)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 6, Type_q = 2, Name = "Možno súvisí (Udalosť môže, ale nemusí byť spôsobená liekom, príčinnú súvislosť nie je možné posúdiť s väčšou istotou)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 7, Type_q = 2, Name = "Pravdepodobne súvisí (Liek je najpravdepodobnejšou príčinou udalosti, ale nemožno vylúčiť iné príčiny)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 8, Type_q = 2, Name = "Takmer určite súvisí (Liek je takmer určite príčinou udalosti, neexistujú žiadne iné zjavné alternatívne vysvetlenia)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        //Zavaznost
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 9, Type_q = 3, Name = "Nezávažné", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 10, Type_q = 3, Name = "Život ohrozujúce", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 11, Type_q = 3, Name = "Hospitalizácia (začatá alebo predĺžená)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 12, Type_q = 3, Name = "Zdravotné postihnutie", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 13, Type_q = 3, Name = "Vrodená anomália", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 14, Type_q = 3, Name = "Smrť", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 15, Type_q = 3, Name = "Závažné podľa názoru skúšajúceho lekára", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        //Intenzita
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 16, Type_q = 4, Name = "Mierna (Nespôsobuje obmedzenie bežných činností, pacient môže pociťovať mierne nepohodlie)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 17, Type_q = 4, Name = "Stredne ťažká (Spôsobuje určité obmedzenia bežných aktivít, pacient môže pociťovať nepríjemné nepohodlie)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 18, Type_q = 4, Name = "Ťažká (Spôsobuje neschopnosť vykonávať bežné činnosti, pacient môže pociťovať neznesiteľné nepohodlie alebo bolesť)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        //Vplyv na liečbu
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 19, Type_q = 5, Name = "Bez následkov", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 20, Type_q = 5, Name = "Zmeny v liečbe", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 21, Type_q = 5, Name = "Zníženie dávky", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 22, Type_q = 5, Name = "Symptomatická liečba", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 23, Type_q = 5, Name = "Hospitalizácia", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        //Vysledok
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 24, Type_q = 6, Name = "Prestala", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 25, Type_q = 6, Name = "Pokračuje", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });

        #endregion

    }
}
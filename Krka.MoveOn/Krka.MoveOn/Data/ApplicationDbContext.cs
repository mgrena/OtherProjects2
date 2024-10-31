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
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 25, Type_q = 7, Name = "Chloprprotixen", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
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
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 1, Type_q = 1, Name = "Levodopa/Karbidopa", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 2, Type_q = 1, Name = "Levodopa/Benserazid", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 3, Type_q = 1, Name = "Entakapon", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 4, Type_q = 1, Name = "Tolkapon", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 5, Type_q = 1, Name = "Opikapon", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 6, Type_q = 1, Name = "Rasagilín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 7, Type_q = 1, Name = "Pramipexol", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 8, Type_q = 1, Name = "Ropinirol", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 9, Type_q = 1, Name = "Rotigotín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 10, Type_q = 1, Name = "Apomorfín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialActiveIngredient>().HasData(new DialActiveIngredient() { Id = 11, Type_q = 1, Name = "Amantadín", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });

        #endregion

        #region "DialIndication"
        //treat_3
        modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 1, Type_q = 1, Name = "Pruhy močenia", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 2, Type_q = 1, Name = "Erektilná dysfunkcia", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 3, Type_q = 1, Name = "Zápcha", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 4, Type_q = 1, Name = "Porucha spánku", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 5, Type_q = 1, Name = "Ortostatická hypotenzia", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 6, Type_q = 1, Name = "Depresia", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 7, Type_q = 1, Name = "Úzkosť", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 8, Type_q = 1, Name = "Psychóza (halucinácie, bludy)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialIndication>().HasData(new DialIndication() { Id = 9, Type_q = 1, Name = "Iné...", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        #endregion

        #region "DialMH"
        modelBuilder.Entity<DialMH>().HasData(new DialMH() { Id = 1, Type_q = 1, Number = "1", Name = "Jednostranné príznaky", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialMH>().HasData(new DialMH() { Id = 2, Type_q = 1, Number = "1,5", Name = "Jednostranné a axiálne príznaky (hypofónia, hypomímia, flekčné držanie tela) ", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialMH>().HasData(new DialMH() { Id = 3, Type_q = 1, Number = "2", Name = "Obojstranné príznaky bez poruchy rovnováhy", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialMH>().HasData(new DialMH() { Id = 4, Type_q = 1, Number = "2,5", Name = "Obojstranné príznaky s miernou poruchou rovnováhy (schopnosť vyrovnať postoj pri pull teste)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialMH>().HasData(new DialMH() { Id = 5, Type_q = 1, Number = "3", Name = "Mierne až stredné obojstranné príznaky, posturálna instabilita, pacient je stále sebestačný", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialMH>().HasData(new DialMH() { Id = 6, Type_q = 1, Number = "4", Name = "Ťažké postihnutie, no pacient je schopný chodiť alebo stáť bez pomoci", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialMH>().HasData(new DialMH() { Id = 7, Type_q = 1, Number = "5", Name = "Pacient je odkázaný na vozík alebo posteľ", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        #endregion

        #region "Dial Exclusion"
        //exc_2
        modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 1, Type_q = 1, Name = "Pri návšteve pacienta na mieste", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 2, Type_q = 1, Name = "Na diaľku prostredníctvom telefonického hovoru", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 3, Type_q = 1, Name = "Na diaľku prostredníctvom elektronických médií.", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        //exc_3
        modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 4, Type_q = 2, Name = "Výskyt závažnej nežiaducej reakcie počas pozorovacieho obdobia v tejto štúdii. *", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 5, Type_q = 2, Name = "Smrť", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 6, Type_q = 2, Name = "Hospitalizácia", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 7, Type_q = 2, Name = "Rozhodnutie pacienta ukončiť liečbu a odvolanie jeho informovaného súhlasu.", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 8, Type_q = 2, Name = "Rozhodnutie pacienta ukončiť liečbu a odvolanie informovaného súhlasu a GDPR formulára.", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 9, Type_q = 2, Name = "Bezpečnosť pacienta (napr. rozhodnutie skúšajúceho vylúčiť pacienta zo štúdie v jeho najlepšom záujme, nežiaduce účinky vyžadujúce medikamentózny zásah alebo ukončenie liečby). *", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialExclusion>().HasData(new DialExclusion() { Id = 10, Type_q = 2, Name = "O alebo zhoršenie existujúceho ochorenia počas štúdie, ktoré si vyžaduje používanie liekov, ktoré nie sú povolené v spojení so súhrnom charakteristických vlastností lieku použitých liekov.", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
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
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 14, Type_q = 3, Name = "Smrť", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 15, Type_q = 3, Name = "Závažné podľa názoru skúšajúceho lekára", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        //Intenzita
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 16, Type_q = 4, Name = "Mierna (Nespôsobuje obmedzenie bežných činností, pacient môže pociťovať mierne nepohodlie)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 17, Type_q = 4, Name = "Stredne ťažká (Spôsobuje určité obmedzenia bežných aktivít, pacient môže pociťovať nepríjemné nepohodlie)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
        modelBuilder.Entity<DialAdverseEffect>().HasData(new DialAdverseEffect() { Id = 18, Type_q = 4, Name = "Ťažká (Spôsobuje neschopnosť vykonávať bežné činnosti, pacient môže pociťovať neznesiteľné nepohodlie alebo bolesť)", CreatedAt = new(2024, 10, 10), ModifiedAt = new(2024, 10, 10) });
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
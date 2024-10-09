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

        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 1, Type_q = 1, Name = "Muž", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
        modelBuilder.Entity<DialQGeneral>().HasData(new DialQGeneral() { Id = 2, Type_q = 1, Name = "Žena", CreatedAt = new(2024, 10, 9), ModifiedAt = new(2024, 10, 9) });
    }
}
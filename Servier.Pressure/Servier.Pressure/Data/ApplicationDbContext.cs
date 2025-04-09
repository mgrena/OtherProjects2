using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Servier.Pressure.Data.Lists;
using Servier.Pressure.Data.Models;

namespace Servier.Pressure.Data; 
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options) 
{
    /// <summary>
    /// List of log entries
    /// </summary>
    public DbSet<LogEntity> Logs { get; set; } = null!;

    public DbSet<Patient> Patients { get; set; }
    public DbSet<WorkPlace> WorkPlaces { get; set; }

    public DbSet<DyslipidemiaDrug> DyslipidemiaDrugs { get; set; }
    public DbSet<TreatmentMonotherapyDrug> TreatmentMonotherapyDrugs { get; set; }
    public DbSet<TreatmentMultitherapyDrug> TreatmentMultitherapyDrugs { get; set; }

    public DbSet<TreatmentMonotherapy> TreatmentMonotherapies { get; set; }
    public DbSet<TreatmentMultitherapy> TreatmentMultitherapies { get; set; }

    // introduction
    public DbSet<InformedConsentCompetence> InformedConsentCompetences { get; set; }
    public DbSet<TreatmentBefore> TreatmentsBefore { get; set; }
    // first visit
    public DbSet<Treatment1Visit> Treatments1Visit { get; set; }
    public DbSet<DemographyHistory> DemographyHistories { get; set; }
    public DbSet<PhysicalExamination1> PhysicalExaminations1 { get; set; }
    public DbSet<LaboratoryTest> LaboratoryTests { get; set; }
    // second visit
    public DbSet<Treatment2Visit> Treatments2Visit { get; set; }
    public DbSet<PhysicalExamination2> PhysicalExaminations2 { get; set; }

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
        #region DyslipidemiaDrugs
        modelBuilder.Entity<DyslipidemiaDrug>().HasData(new DyslipidemiaDrug() { Id = 1, Name = "žiadna", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<DyslipidemiaDrug>().HasData(new DyslipidemiaDrug() { Id = 2, Name = "statín", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<DyslipidemiaDrug>().HasData(new DyslipidemiaDrug() { Id = 3, Name = "fibrát", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<DyslipidemiaDrug>().HasData(new DyslipidemiaDrug() { Id = 4, Name = "ezetimib", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<DyslipidemiaDrug>().HasData(new DyslipidemiaDrug() { Id = 5, Name = "statín/ezetimib", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<DyslipidemiaDrug>().HasData(new DyslipidemiaDrug() { Id = 6, Name = "kys. bempedoová", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<DyslipidemiaDrug>().HasData(new DyslipidemiaDrug() { Id = 7, Name = "kys. bempedoová / ezetimib", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<DyslipidemiaDrug>().HasData(new DyslipidemiaDrug() { Id = 8, Name = "inhibítor PCSK9", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<DyslipidemiaDrug>().HasData(new DyslipidemiaDrug() { Id = 9, Name = "inclisiran", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<DyslipidemiaDrug>().HasData(new DyslipidemiaDrug() { Id = 10, Name = "„polypill“", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<DyslipidemiaDrug>().HasData(new DyslipidemiaDrug() { Id = 11, Name = "výživový doplnok", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<DyslipidemiaDrug>().HasData(new DyslipidemiaDrug() { Id = 12, Name = "neznáma", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        #endregion

        #region TreatmentMonotherapyDrug
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 1, Monotherapy = MonotherapyEnum.ACEInhibitor, IsAldosteroneAntagonist = false, Order = 1, Name = "enalapril", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 2, Monotherapy = MonotherapyEnum.ACEInhibitor, IsAldosteroneAntagonist = false, Order = 2, Name = "fosinopril", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 3, Monotherapy = MonotherapyEnum.ACEInhibitor, IsAldosteroneAntagonist = false, Order = 3, Name = "imidapril", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 4, Monotherapy = MonotherapyEnum.ACEInhibitor, IsAldosteroneAntagonist = false, Order = 4, Name = "kaptopril", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 5, Monotherapy = MonotherapyEnum.ACEInhibitor, IsAldosteroneAntagonist = false, Order = 5, Name = "lisinopril", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 6, Monotherapy = MonotherapyEnum.ACEInhibitor, IsAldosteroneAntagonist = false, Order = 6, Name = "perindopril", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 7, Monotherapy = MonotherapyEnum.ACEInhibitor, IsAldosteroneAntagonist = false, Order = 7, Name = "quinapril", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 8, Monotherapy = MonotherapyEnum.ACEInhibitor, IsAldosteroneAntagonist = false, Order = 8, Name = "ramipril", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 9, Monotherapy = MonotherapyEnum.ACEInhibitor, IsAldosteroneAntagonist = false, Order = 9, Name = "trandolapril", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 10, Monotherapy = MonotherapyEnum.AngiotensinIIReceptorBlocker, IsAldosteroneAntagonist = false, Order = 1, Name = "irbesartan", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 11, Monotherapy = MonotherapyEnum.AngiotensinIIReceptorBlocker, IsAldosteroneAntagonist = false, Order = 2, Name = "kandesartan", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 12, Monotherapy = MonotherapyEnum.AngiotensinIIReceptorBlocker, IsAldosteroneAntagonist = false, Order = 3, Name = "losartan", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 13, Monotherapy = MonotherapyEnum.AngiotensinIIReceptorBlocker, IsAldosteroneAntagonist = false, Order = 4, Name = "telmisartan", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 14, Monotherapy = MonotherapyEnum.AngiotensinIIReceptorBlocker, IsAldosteroneAntagonist = false, Order = 5, Name = "valsartan", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 15, Monotherapy = MonotherapyEnum.CalciumChannelBlocker, IsAldosteroneAntagonist = false, Order = 1, Name = "amlodipín", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 16, Monotherapy = MonotherapyEnum.CalciumChannelBlocker, IsAldosteroneAntagonist = false, Order = 2, Name = "felodipín", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 17, Monotherapy = MonotherapyEnum.CalciumChannelBlocker, IsAldosteroneAntagonist = false, Order = 3, Name = "isradipín", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 18, Monotherapy = MonotherapyEnum.CalciumChannelBlocker, IsAldosteroneAntagonist = false, Order = 4, Name = "lacidipín", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 19, Monotherapy = MonotherapyEnum.CalciumChannelBlocker, IsAldosteroneAntagonist = false, Order = 5, Name = "lercandipín", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 20, Monotherapy = MonotherapyEnum.CalciumChannelBlocker, IsAldosteroneAntagonist = false, Order = 6, Name = "nifedipín", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 21, Monotherapy = MonotherapyEnum.CalciumChannelBlocker, IsAldosteroneAntagonist = false, Order = 7, Name = "nitrendipín", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 22, Monotherapy = MonotherapyEnum.CalciumChannelBlocker, IsAldosteroneAntagonist = false, Order = 8, Name = "verapamil", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 23, Monotherapy = MonotherapyEnum.BetaBlocker, IsAldosteroneAntagonist = false, Order = 1, Name = "atenolol", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 24, Monotherapy = MonotherapyEnum.BetaBlocker, IsAldosteroneAntagonist = false, Order = 2, Name = "betaxolol", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 25, Monotherapy = MonotherapyEnum.BetaBlocker, IsAldosteroneAntagonist = false, Order = 3, Name = "bisoprolol", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 26, Monotherapy = MonotherapyEnum.BetaBlocker, IsAldosteroneAntagonist = false, Order = 4, Name = "celiprolol", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 27, Monotherapy = MonotherapyEnum.BetaBlocker, IsAldosteroneAntagonist = false, Order = 5, Name = "esmololol", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 28, Monotherapy = MonotherapyEnum.BetaBlocker, IsAldosteroneAntagonist = false, Order = 6, Name = "karvedilol", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 29, Monotherapy = MonotherapyEnum.BetaBlocker, IsAldosteroneAntagonist = false, Order = 7, Name = "labetalol", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 30, Monotherapy = MonotherapyEnum.BetaBlocker, IsAldosteroneAntagonist = false, Order = 8, Name = "metipranolol", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 31, Monotherapy = MonotherapyEnum.BetaBlocker, IsAldosteroneAntagonist = false, Order = 9, Name = "metoprolol", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 32, Monotherapy = MonotherapyEnum.BetaBlocker, IsAldosteroneAntagonist = false, Order = 10, Name = "nebivolol", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 33, Monotherapy = MonotherapyEnum.Diuretic, IsAldosteroneAntagonist = false, Order = 1, Name = "HCTZ", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 34, Monotherapy = MonotherapyEnum.Diuretic, IsAldosteroneAntagonist = false, Order = 2, Name = "indapamid", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 35, Monotherapy = MonotherapyEnum.Diuretic, IsAldosteroneAntagonist = false, Order = 3, Name = "metipamid", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 36, Monotherapy = MonotherapyEnum.Diuretic, IsAldosteroneAntagonist = false, Order = 4, Name = "antagonista aldosterónu", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 37, Monotherapy = MonotherapyEnum.Diuretic, IsAldosteroneAntagonist = true, Order = 1, Name = "eplerenón", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 38, Monotherapy = MonotherapyEnum.Diuretic, IsAldosteroneAntagonist = true, Order = 2, Name = "finerenón", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 39, Monotherapy = MonotherapyEnum.Diuretic, IsAldosteroneAntagonist = true, Order = 3, Name = "spironolaktón", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 40, Monotherapy = MonotherapyEnum.Other, IsAldosteroneAntagonist = false, Order = 1, Name = "doxazosín", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 41, Monotherapy = MonotherapyEnum.Other, IsAldosteroneAntagonist = false, Order = 2, Name = "metyldopa", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 42, Monotherapy = MonotherapyEnum.Other, IsAldosteroneAntagonist = false, Order = 3, Name = "metipamid", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 43, Monotherapy = MonotherapyEnum.Other, IsAldosteroneAntagonist = false, Order = 4, Name = "moxonidín", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 44, Monotherapy = MonotherapyEnum.Other, IsAldosteroneAntagonist = false, Order = 5, Name = "rilmenidín", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMonotherapyDrug>().HasData(new TreatmentMonotherapyDrug() { Id = 45, Monotherapy = MonotherapyEnum.Other, IsAldosteroneAntagonist = false, Order = 6, Name = "urapidil", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        #endregion

        #region TreatmentMultitherapyDrug
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 1, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 1, Name = "amilorid / HCTZ", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 2, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 2, Name = "amlodipín / bisoprolol", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 3, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 3, Name = "bisoprolol / HCTZ", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 4, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 4, Name = "bisoprolol / perindopril", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 5, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 5, Name = "fosinopril / HCTZ", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 6, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 6, Name = "irbesartan / HCTZ", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 7, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 7, Name = "kandesartan / HCTZ", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 8, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 8, Name = "lisinopril / amlodipín", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 9, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 9, Name = "lisinopril / HCTZ", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 10, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 10, Name = "losartan / amlodipín", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 11, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 11, Name = "losartan / HCTZ", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 12, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 12, Name = "nebivolol / HCTZ", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 13, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 13, Name = "perindopril / indapamid", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 14, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 14, Name = "perindopril / amlodipín", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 15, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 15, Name = "quinapril / HCTZ", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 16, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 16, Name = "ramipril / amlodipín", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 17, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 17, Name = "ramipril / bisoprolol", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 18, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 18, Name = "ramipril / HCTZ", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 19, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 19, Name = "telmisartan / amlodipín", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 20, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 20, Name = "telmisartan / HCTZ", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 21, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 21, Name = "trandolapril / verapamil", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 22, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 22, Name = "valsartan / amlodipín", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 23, Multitherapy = MultitherapyEnum.Antihypertensive2, Order = 23, Name = "valsartan / HCTZ", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 24, Multitherapy = MultitherapyEnum.Antihypertensive3, Order = 1, Name = "perindopril / amlodipín / indapamid", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 25, Multitherapy = MultitherapyEnum.Antihypertensive3, Order = 2, Name = "perindopril / indapamid / amlodipín", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 26, Multitherapy = MultitherapyEnum.Antihypertensive3, Order = 3, Name = "valsartan / amlodipín / HCTZ", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 27, Multitherapy = MultitherapyEnum.WithHypolypedidemic, Order = 1, Name = "atorvastatín / amlodipín", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 28, Multitherapy = MultitherapyEnum.WithHypolypedidemic, Order = 2, Name = "atorvastatín / perindopril / amlodipín", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        modelBuilder.Entity<TreatmentMultitherapyDrug>().HasData(new TreatmentMultitherapyDrug() { Id = 29, Multitherapy = MultitherapyEnum.WithHypolypedidemic, Order = 3, Name = "rosuvastatín / perindopril / indapamid", CreatedAt = new(2025, 03, 27), ModifiedAt = new(2025, 03, 27) });
        #endregion
    }
}
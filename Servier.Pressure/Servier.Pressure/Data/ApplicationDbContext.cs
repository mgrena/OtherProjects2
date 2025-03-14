using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Servier.Pressure.Data; 
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options) 
{
    /// <summary>
    /// List of log entries
    /// </summary>
    public DbSet<LogEntity> Logs { get; set; } = null!;

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
    }
}
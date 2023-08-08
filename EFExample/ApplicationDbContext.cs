using EFExample.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;

namespace EFExample;

public class ApplicationDbContext : DbContext
{
    private const string ConnectionString = "Host=localhost;Username=postgres;Password=admin;Database=Maxima";


    // public DbSet<Circle> Circles { get; set; }
    // public DbSet<Square> Squares { get; set; }
    //
    public ApplicationDbContext()
    {
       Database.EnsureDeleted();
       Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        
        optionsBuilder.UseNpgsql(ConnectionString);
        
        
#if DEBUG
        optionsBuilder.EnableSensitiveDataLogging();
#endif
        
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
    }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<User>()
    //         .HasOne(x => x.School)
    //         .WithMany(c => c.Users)
    //         .OnDelete(DeleteBehavior.Cascade);
    //     
    //     base.OnModelCreating(modelBuilder);
    // }

    public DbSet<User> Users { get; set; }
    public DbSet<School> Schools { get; set; }
}
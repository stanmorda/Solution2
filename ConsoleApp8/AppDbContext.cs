using ConsoleApp8.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ConsoleApp8;

public class AppDbContext : DbContext
{
    private const string ConnectionString = "Host=localhost;Username=postgres;Password=admin;Database=Maxima";

    public AppDbContext()
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Circle>().ToTable("Circles");
        modelBuilder.Entity<Square>().ToTable("Squares");
    }

    public DbSet<Figure> Figures { get; set; }
    public DbSet<Circle> Circles { get; set; }
    public DbSet<Square> Squares { get; set; }

    
}
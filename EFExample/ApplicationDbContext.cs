using EFExample.Model;
using Microsoft.EntityFrameworkCore;

namespace EFExample;

public class ApplicationDbContext : DbContext
{
    private const string ConnectionString = "Host=localhost;Username=postgres;Password=admin;Database=Maxima";
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(ConnectionString);
    }

    public DbSet<User> Users { get; set; }
}
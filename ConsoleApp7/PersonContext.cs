using ConsoleApp7.models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp7;

public class PersonContext : DbContext
{
    private readonly string _connectionString = "Host=localhost;Username=postgres;Password=admin;Database=Maxima";
    
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(_connectionString);

    public DbSet<Person> Clients { get; set; }
}
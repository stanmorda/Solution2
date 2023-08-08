// See https://aka.ms/new-console-template for more information


using Microsoft.EntityFrameworkCore;


var context = new AppDbContext();
var data = context.Clients.ToArray();


Console.WriteLine("Hello, World!");

class AppDbContext : DbContext
{
    private readonly string _connectionString = "Host=localhost;Username=postgres;Password=admin;Database=Maxima";

    
    public DbSet<Person> Clients { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(_connectionString);
}

class Person
{
    public int PersonID { get; set; }
    public string FirstName { get; set; }
}
// See https://aka.ms/new-console-template for more information


using ConsoleApp7;
using Microsoft.EntityFrameworkCore;

// var connectionString = "Host=localhost;Username=postgres;Password=admin;Database=Maxima";
//
// var optionsBuilder = new DbContextOptionsBuilder<PersonContext>();
// optionsBuilder.UseNpgsql(connectionString);

using var dbContext = new PersonContext();

var data = dbContext.Clients.ToArray();
Console.ReadLine();


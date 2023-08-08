// See https://aka.ms/new-console-template for more information

using System.Data.Common;
using Npgsql;

async Task GetClients(NpgsqlDataSource dataSource1)
{
    var clients = new List<Person>();
    var commandText = "SELECT * FROM \"Clients\" WHERE \"PersonID\"=111";
// Retrieve all rows
    await using (var cmd = dataSource1.CreateCommand(commandText))
    {
        await using (var reader = await cmd.ExecuteReaderAsync())
        {
            while (await reader.ReadAsync())
            {
                var id = reader.GetInt32(0);
                var name = reader.GetString(1);
                var city = reader.GetString(4);
                var person = new Person(id, name, city);
                clients.Add(person);
                Console.WriteLine();
            }
        }
    }
}

async Task Insert(NpgsqlDataSource npgsqlDataSource)
{
    var commandText = "INSERT INTO \"Clients\"(\"PersonID\", \"FirstName\", \"City\", \"Gender\") " +
                      "VALUES(111, 'Masha', 'City', 'F')";

// Insert some data
    await using (var cmd = npgsqlDataSource.CreateCommand(commandText))
    {
        var result = await cmd.ExecuteNonQueryAsync();
        Console.WriteLine(result);
    }
}

var connectionString = "Host=localhost;Username=postgres;Password=admin;Database=Maxima";


await using var dataSource = NpgsqlDataSource.Create(connectionString);



//await Insert(dataSource);

//await GetClients(dataSource);

// For functions

int i = 0;

using (var cmd = dataSource.CreateCommand("CALL GetClients()"))
{
    using(var reader = cmd.ExecuteReader())
    {
        while (reader.Read())
        {
            i++;
            Console.WriteLine(reader.GetString(1));
            //var id = reader.GetInt32(0);
            //var name = reader.GetString(1);
            //Console.WriteLine($"{id}:{name}");
        }
    }
}




// For procedures
// using var cmd = new NpgsqlCommand("CALL my_proc(1, 2)", conn);
// using var reader = cmd.ExecuteReader();

Console.WriteLine(i);
Console.ReadLine();

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }

    public Person(int id, string name, string city)
    {
        Id = id;
        Name = name;
        City = city;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, City: {City}";
    }
}

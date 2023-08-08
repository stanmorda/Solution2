// See https://aka.ms/new-console-template for more information


using ConsoleApp8;
using ConsoleApp8.Model;

await using (var dbContext = new AppDbContext())
{
    if (!dbContext.Database.CanConnect())
    {
        throw new Exception("Can not connect to DB");
    }

    var fig1 = new Circle() { Name = "Circle234545" };
    var fig2 = new Circle() { Name = "Circle123" };
    var fig3 = new Square() { Name = "Square1234" };
    var fig4 = new Square() { Name = "Square123" };

    var data = new Figure[] { fig1, fig2, fig3, fig4 };
    
    dbContext.Figures.AddRange(data);
    await dbContext.SaveChangesAsync();
}

await using (var dbContext = new AppDbContext())
{
    if (!dbContext.Database.CanConnect())
    {
        throw new Exception("Can not connect to DB");
    }

    var items = dbContext.Figures.ToArray();
    Console.WriteLine(items.Length);
}

Console.WriteLine("Success!");
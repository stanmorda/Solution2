using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp8.Model;

public class Figure
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Area { get; set; }
}

//[Table("Circles")]
public class Circle : Figure
{
    public double Radius { get; set; }
}


//[Table("Squares")]
public class Square : Figure
{
    public double A { get; set; }
}
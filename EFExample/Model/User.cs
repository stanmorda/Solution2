using System.ComponentModel.DataAnnotations;

namespace EFExample.Model;

public class User
{
    public int Id { get; set; }
    
    [MaxLength(100)]
    public string Name { get; set; }
    
    [Range(0, 199)]
    public int Age { get; set; }
    
    [EnumDataType(typeof(Genger))]

    public int Gender { get; set; }

    public int? SchoolId { get; set; }
    
    public School? School { get; set; }
    
    
    
    public User()
    {
    }

    public User(int id, string name, int age, int schoolId)
    {
        Id = id;
        Name = name;
        Age = age;
        SchoolId = schoolId;
    }

    public User(int id, string name, int age, School? school)
    {
        Id = id;
        Name = name;
        Age = age;
        School = school;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Age: {Age}";
    }
}

public enum Genger
{
    Male, 
    Female
}
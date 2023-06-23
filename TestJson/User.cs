namespace TestJson;

public class User
{
    public string Name { get; set; }
    public byte Age { get; set; }
    public Mother Mother { get; set; }
    public string[] Children { get; set; }
    public bool Married { get; set; }
    public string Dog { get; set; }

    public User(string name, byte age, Mother mother, string[] children, bool married, string dog)
    {
        Name = name;
        Age = age;
        Mother = mother;
        Children = children;
        Married = married;
        Dog = dog;
    }
}

public class Mother
{
    public string Name { get; set; }
    public byte Age { get; set; }

    public Mother(string name, byte age)
    {
        Name = name;
        Age = age;
    }
}
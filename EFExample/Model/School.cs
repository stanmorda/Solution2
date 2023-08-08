namespace EFExample.Model;

public class School
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string City { get; set; }


    public School(int id, string title, string city)
    {
        Id = id;
        Title = title;
        City = city;
    }

    public List<User> Users { get; set; }
}
using System;

namespace Library
{
    [AttributeUsage(AttributeTargets.All)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }

        public AuthorAttribute(string name, string createDate)
        {
            Name = name;
            if (DateTime.TryParse(createDate, out var date))
            {
                CreateDate = date;
            }
            else
            {
                CreateDate = DateTime.Now;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, CreateDate: {CreateDate}";
        }
    }
}
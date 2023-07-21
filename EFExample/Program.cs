using EFExample;
using EFExample.Model;
using Microsoft.EntityFrameworkCore;






await using (var dbContext = new ApplicationDbContext())
{
    if (!dbContext.Database.CanConnect())
    {
        throw new Exception("Can not connect to DB");
    }

    var dbUsers = dbContext.Users;
    var users = dbUsers.ToArray(); // get data from Database


// var listOfUsrs = new List<User>();
// for (int i = 10; i < 100; i++)
// {
//     listOfUsrs.Add(new User(i, $"Name_{i}", i));
// }
//
// await AddRangeOfUsers(listOfUsrs);

    await RemoveRangeOfUsers(x => x.Id >= 10);
}


return;

var userId = 1;
var user = GetUserById(userId);
if (user != null)
{
    Console.WriteLine(user);
    await UpdateUserById(1, user.Age + 1);
    Console.WriteLine(user);
}
else
{
    Console.WriteLine($"User not found {userId}");
}
//

//users = dbUsers.ToArray(); // get data from Database

Console.ReadLine();

User? GetUserById(int userId)
{
    return users.FirstOrDefault(x => x.Id == userId);
}


async Task AddRangeOfUsers(IEnumerable<User> usersRange)
{
    dbUsers.AddRange(usersRange);
    await Save();
}


async Task RemoveRangeOfUsers(Func<User, bool> funForRemove)
{
    dbUsers.RemoveRange(users.Where(funForRemove));
    await Save();
}

async Task AddUser()
{
    var user = new User(2, "Petr", 20);
    if (users.All(x => x.Id != user.Id))
    {
        // var1
        dbUsers.Add(user);
        await Save();
    }
}

async Task RemoveUserById(int userId)
{
    var user = GetUserById(userId);
    if (user != null)
    {
        dbUsers.Remove(user);
        await Save();
    }
}

async Task UpdateUserById(int userId, int age)
{
    var user = GetUserById(userId);
    if (user != null)
    {
        user.Age = age;
        user.Name = user.Name.TrimEnd();
        await Save();
    }
}

async Task Save()
{
    await dbContext.SaveChangesAsync();
}
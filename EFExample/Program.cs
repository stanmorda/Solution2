using EFExample;
using EFExample.Model;
using Microsoft.EntityFrameworkCore;






await using (var dbContext = new ApplicationDbContext())
{
    if (!dbContext.Database.CanConnect())
    {
        throw new Exception("Can not connect to DB");
    }

    var school1 = new School(3, "School 3", "Ivanovo");
    var school2 = new School(4, "School 4", "Pskov");
    
    var sc = dbContext.Schools;
    sc.AddRange(school1, school2);
    
    //var user1 = new User(3, "Nikolay", 9, school1.Id);
    var user1 = new User(3, "Nikolay", 9, school1);
    
    var user2 = new User(4, "Timofey", 8, school2.Id);
    
    var dbUsers = dbContext.Users;
    dbUsers.Add(user1);
    dbUsers.Add(user2);
    
    dbContext.SaveChanges();

    var data = dbContext.Users
       // .Include(x => x.School)
        .Where(x=>x.School != null)
        .Select(x => new { x.Name, x.School.City });
 
}



return;

// var userId = 1;
// var user = GetUserById(userId);
// if (user != null)
// {
//     Console.WriteLine(user);
//     await UpdateUserById(1, user.Age + 1);
//     Console.WriteLine(user);
// }
// else
// {
//     Console.WriteLine($"User not found {userId}");
// }
//

//users = dbUsers.ToArray(); // get data from Database

Console.ReadLine();

// User? GetUserById(int userId)
// {
//     return users.FirstOrDefault(x => x.Id == userId);
// }
//
//
// async Task AddRangeOfUsers(IEnumerable<User> usersRange)
// {
//     dbUsers.AddRange(usersRange);
//     await Save();
// }
//
//
// async Task RemoveRangeOfUsers(Func<User, bool> funForRemove)
// {
//     dbUsers.RemoveRange(users.Where(funForRemove));
//     await Save();
// }
//
// async Task AddUser()
// {
//     var user = new User(2, "Petr", 20);
//     if (users.All(x => x.Id != user.Id))
//     {
//         // var1
//         dbUsers.Add(user);
//         await Save();
//     }
// }
//
// async Task RemoveUserById(int userId)
// {
//     var user = GetUserById(userId);
//     if (user != null)
//     {
//         dbUsers.Remove(user);
//         await Save();
//     }
// }
//
// async Task UpdateUserById(int userId, int age)
// {
//     var user = GetUserById(userId);
//     if (user != null)
//     {
//         user.Age = age;
//         user.Name = user.Name.TrimEnd();
//         await Save();
//     }
// }
//
// async Task Save()
// {
//     await dbContext.SaveChangesAsync();
// }
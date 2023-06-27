// See https://aka.ms/new-console-template for more information


using Newtonsoft.Json;
using TestJson;

var mother = new Mother("Ольга", 58);
var user = new User("Иван", 37, mother, new[] { "Маша", "Игорь", "Таня" }, true, null);

string json = JsonConvert.SerializeObject(user);


User userFromJson = JsonConvert.DeserializeObject<User>(json);

Console.WriteLine(json);
Console.ReadLine();
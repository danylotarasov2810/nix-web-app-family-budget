using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

User user = new User();
user.Name = "Sasha";
user.Surname = "Vlasov";
user.Relationdegree = "Father";
user.Years = 45;
user.Email = "sashavlasov@gmail.com";
user.Phone = "+380509999999";
var option = new JsonSerializerOptions
{
    IncludeFields = true,
    WriteIndented = true,
};
string str = JsonSerializer.Serialize(user, option);
Console.WriteLine(str);
User user1 = JsonSerializer.Deserialize<User>(str, option);
user1.Info();

class User
{
    private int id;

    public string Name { get; set; }
    public string Surname { get; set; }

    public string Relationdegree { get; set; }

    public int Years { get; set; }
    public string Email { get; set; }
    public string Phone{ get; set; }

    public void Info()
    {
        Console.WriteLine($"{id} --- {Name} --- {Surname} --- {Relationdegree} --- {Years} --- {Email} --- {Phone}");
    }

}
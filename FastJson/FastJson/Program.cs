using FastJson;
using System.Text.Json;

var person = new Person
{
    FirstName = "Fulano",
    LastName = "DaSilva"
};

// customize
var option = new JsonSerializerOptions
{
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
};

var json = JsonSerializer.Serialize(person, option);


Console.WriteLine(json);
Console.ReadKey();

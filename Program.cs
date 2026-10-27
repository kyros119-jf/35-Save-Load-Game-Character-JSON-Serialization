using System.Text.Json;

GameCharacter hero = new GameCharacter()
{
    Name = "Arthas",
    ClassType = "Paladin",
    Level = 10,
    Health = 100,
    Mana = 50
};

string jsonString = JsonSerializer.Serialize(hero);
File.WriteAllText("character.json", jsonString);

Console.WriteLine("Character saved to character.json");
Console.WriteLine();
string jsonStringFromFile = File.ReadAllText("character.json");

GameCharacter characterFromFile = JsonSerializer.Deserialize<GameCharacter>(jsonStringFromFile);

Console.WriteLine("Loading character...");
Console.WriteLine();
Console.WriteLine($"Name: {characterFromFile.Name}");
Console.WriteLine($"Class: {characterFromFile.ClassType}");
Console.WriteLine($"Level: {characterFromFile.Level}");
Console.WriteLine($"Health: {characterFromFile.Health}");
Console.WriteLine($"Mana: {characterFromFile.Mana}");






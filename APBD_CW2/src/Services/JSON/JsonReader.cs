using System.Text.Json;
using APBD_CW2.Models;

namespace APBD_CW2.Services;

public class JsonReader
{
    public static void ReadJson(string json)
    {
        // 1. Read the JSON file into a string
        string jsonString = File.ReadAllText("DataBase.json");

        // 2. Deserialize into the wrapper class
        LibraryData data = JsonSerializer.Deserialize<LibraryData>(jsonString);

        // 3. Extract your lists!
        List<User> users = data.Users;
        List<Item> items = data.Items;

        // --- Testing if it worked ---
        Console.WriteLine($"Loaded {users.Count} users:");
        foreach (var user in users)
        {
            Console.WriteLine($"- {user.FirstName} {user.LastName} ({user.GetType().Name})");
        }

        Console.WriteLine($"\nLoaded {items.Count} items:");
        foreach (var item in items)
        {
            Console.WriteLine($"- {item.Name} ({item.GetType().Name})");
        }
    }

}
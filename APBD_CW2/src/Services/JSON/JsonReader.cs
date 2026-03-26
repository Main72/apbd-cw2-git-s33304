using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using APBD_CW2.Models;
using System;

namespace APBD_CW2.Services;

public class JsonReader
{
    
    public static LibraryData ReadJson(string filePath)
    {
      
        string jsonString = File.ReadAllText(filePath);

      
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        LibraryData data = JsonSerializer.Deserialize<LibraryData>(jsonString, options);

        List<User> users = data.Users;
        List<Item> items = data.Items;

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
        return data;
    }
}
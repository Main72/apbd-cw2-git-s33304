using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using APBD_CW2.Models;

namespace APBD_CW2.Services;

public class JsonWriter
{
    public static void AddUser(string filePath, User newUser)
    {
        LibraryData currentData;
        
        if (File.Exists(filePath))
        {
            string existingJson = File.ReadAllText(filePath);
            var readOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            currentData = JsonSerializer.Deserialize<LibraryData>(existingJson, readOptions) 
                          ?? new LibraryData { Users = new List<User>(), Items = new List<Item>() };
        }
        else
        {
            currentData = new LibraryData { Users = new List<User>(), Items = new List<Item>() };
        }

        currentData.Users.Add(newUser);

     
        var writeOptions = new JsonSerializerOptions 
        { 
            WriteIndented = true 
        };
        
        string updatedJsonString = JsonSerializer.Serialize(currentData, writeOptions);
        
        File.WriteAllText(filePath, updatedJsonString);

        Console.WriteLine($"\n[Success] Added {newUser.FirstName} {newUser.LastName} to the database!");
    }
}
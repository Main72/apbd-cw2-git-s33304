using System.Text.Json;

namespace APBD_CW2.Models;

public class DataRepository
{
    private readonly string _filePath;
    private readonly JsonSerializerOptions _options;

    public DataRepository(string filePath = "DataBase.json")
    {
        _filePath = filePath;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true, WriteIndented = true };
    }

    public LibraryData Load()
    {
        if (!File.Exists(_filePath)) return new LibraryData();
        string json = File.ReadAllText(_filePath);
        return JsonSerializer.Deserialize<LibraryData>(json, _options) ?? new LibraryData();
    }

    public void Save(LibraryData data)
    {
        string json = JsonSerializer.Serialize(data, _options);
        File.WriteAllText(_filePath, json);
    }
}
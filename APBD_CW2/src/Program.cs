using APBD_CW2.Models;
using APBD_CW2.Services;


namespace APBD_CW2;

class Program
{
    static void Main(string[] args)
    {
        
        LibraryData libraryData = JsonReader.ReadJson("DataBase.json");
        Console.WriteLine(libraryData.Users.Count());
        libraryData.CreateItem(new Camera());
        libraryData.Items.ForEach(item => Console.WriteLine(item.Name));
        
    }
}
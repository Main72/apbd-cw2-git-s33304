using APBD_CW2.Models;
using APBD_CW2.Services;


namespace APBD_CW2;

class Program
{
    static void Main(string[] args)
    {
        
        LibraryData libraryData = JsonReader.ReadJson("DataBase.json");
        Console.WriteLine(libraryData.Users.Count());
        ItemService.AddItem(new Camera(),libraryData.Items);
        libraryData.Items.ForEach(item => Console.WriteLine(item.Name));
        
    }
}
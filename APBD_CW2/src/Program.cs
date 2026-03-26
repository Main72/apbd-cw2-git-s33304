using APBD_CW2.Models;
using APBD_CW2.Services;


namespace APBD_CW2;

class Program
{
    static void Main(string[] args)
    {
        List<Item> items = new List<Item>();
        JsonReader jsonReader = new JsonReader();
        jsonReader.
        Laptop l = new Laptop();
        Camera c = new Camera();
        Console.WriteLine("Hello, World! " + c.Description + c.Name);
   
    }
}
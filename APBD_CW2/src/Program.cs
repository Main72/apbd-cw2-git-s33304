using APBD_CW2.Models;


namespace APBD_CW2;

class Program
{
    static void Main(string[] args)
    {
        List<Item> items = new List<Item>();
        Item i = new Item();
        Laptop l = new Laptop();
        Camera c = new Camera();
        Console.WriteLine("Hello, World! " + c.Description + c.Name);
   
    }
}
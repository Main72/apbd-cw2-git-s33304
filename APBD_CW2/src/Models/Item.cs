using APBD_CW2.Enums;
using APBD_CW2.Services;

namespace APBD_CW2.Models;

public abstract class Item
{
    public static ItemService ItemService { get; } = new ItemService();
    private string _name = "Item";
    private static int _id = 0;

    public abstract string Description { get; protected set; }
    public int ItemId { get; } =  ++_id;


    public ItemStatus Status { get; set; } = ItemStatus.Available;
    public string Name
    {
        get { return _name; }
        protected set{ _name = value; }
    }

    public Item()
    {

        Console.WriteLine("Hello " + _name);
    }

    
    
}
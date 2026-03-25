using APBD_CW2.Enums;

namespace APBD_CW2.Models;

public class Item
{
    private string _name = "Item";
    private static int _id = 0;

    public string Description { get; protected set; }
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
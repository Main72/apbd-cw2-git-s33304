using System.Text.Json.Serialization;
using APBD_CW2.Enums;
using APBD_CW2.Services;

namespace APBD_CW2.Models;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "ItemType")]
[JsonDerivedType(typeof(Laptop), typeDiscriminator: "Laptop")]
[JsonDerivedType(typeof(Projector), typeDiscriminator: "Projector")]
[JsonDerivedType(typeof(Camera), typeDiscriminator: "Camera")]
public abstract class Item
{
    private string _name = "Item";
    private static int _id = 0;

    public abstract string Description { get; protected set; }
    
    public int Id { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ItemStatus Status { get; set; } = ItemStatus.Available;
    
    private static int nextItemId = JsonReader.ReadJson("DataBase.json").Items.Max(x => x.Id) + 1;
    
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Item()
    {
        Console.WriteLine("Hello " + _name);
    }
}
using System.Text.Json.Serialization;
using APBD_CW2.Enums;

namespace APBD_CW2.Models;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "ItemType")]
[JsonDerivedType(typeof(Laptop), typeDiscriminator: "Laptop")]
[JsonDerivedType(typeof(Projector), typeDiscriminator: "Projector")]
[JsonDerivedType(typeof(Camera), typeDiscriminator: "Camera")]
public abstract class Item
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ItemStatus Status { get; set; } = ItemStatus.Available;

    public Item() { }
}
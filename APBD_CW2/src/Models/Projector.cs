namespace APBD_CW2.Models;

public class Projector:Item
{
    public Projector()
    {
        Name = "Projector";
        Description = "I am a Projector with id: " + ItemId + " I can show pictures";
 
    }

    public override string Description { get; protected set; }
}
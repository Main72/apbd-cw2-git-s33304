namespace APBD_CW2.Models;

public class Laptop:Item
{
    public Laptop()
    {
        Name = "Laptop";
        Description = "I am a Laptop with id: " + Id+ " I can be your pocket assistant";
  
    }

    public override string Description { get; protected set; }
}
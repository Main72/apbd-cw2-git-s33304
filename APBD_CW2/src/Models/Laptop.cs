namespace APBD_CW2.Models;

public class Laptop:Item
{
    public Laptop()
    {
        Name = "Laptop";
    }
    public Laptop(int ramSizeGb , string processorName)
    {
        Name = "Laptop";
        RamSizeGB = ramSizeGb;
        Processor = processorName;
    }

    public int RamSizeGB { get; set; }
    public string Processor { get; set; }


    public override string Description 
    { 
        get { return $"I am a Laptop with id: {Id}. I can be your pocket assistant."; } 
        protected set { }
    }
}
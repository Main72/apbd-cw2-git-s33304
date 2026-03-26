namespace APBD_CW2.Models;

public class Projector:Item
{
    public Projector()
    {
        Name = "Projector";
      
 
    }
    public Projector(string resolution , int brightnessLumens)
    {
        Name = "Projector";
        Resolution =  resolution;
        BrightnessLumens =  brightnessLumens;
    }

    public string Resolution { get; set; }

    public int BrightnessLumens { get; set; }


    public override string Description 
    { 
        get { return $"I am a Projector with id: {Id } I can show pictures"; } 
        protected set { }
    }
}
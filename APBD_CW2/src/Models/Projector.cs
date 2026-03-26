namespace APBD_CW2.Models;

public class Projector : Item
{
    public string Resolution { get; set; } = string.Empty;
    public int BrightnessLumens { get; set; }

    public Projector() { }
    public Projector(string name, string res, int lumens) { Name = name; Resolution = res; BrightnessLumens = lumens; }
}

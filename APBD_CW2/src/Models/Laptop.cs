namespace APBD_CW2.Models;

public class Laptop : Item
{
    public int RamSizeGB { get; set; }
    public string Processor { get; set; } = string.Empty;
    
    public Laptop() { }
    public Laptop(string name, int ram, string cpu) { Name = name; RamSizeGB = ram; Processor = cpu; }
}



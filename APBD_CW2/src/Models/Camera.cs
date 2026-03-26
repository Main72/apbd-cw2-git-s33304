
namespace APBD_CW2.Models;

public class Camera : Item
{
    public int Megapixels { get; set; }
    public bool IsLensIncluded { get; set; }

    public Camera() { }
    public Camera(string name, int mp, bool lens) { Name = name; Megapixels = mp; IsLensIncluded = lens; }
}
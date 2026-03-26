using APBD_CW2.Enums;

namespace APBD_CW2.Models;

public class Camera:Item
{
    
    public Camera()
    {
        Name = "Camera";
        Description = "I am a Camera with id: " + ItemId+ " I can make photos";
     
    }

    public override string Description { get; protected set; }
}
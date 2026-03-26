using APBD_CW2.Enums;

namespace APBD_CW2.Models;

public class Camera:Item
{
    
    public Camera()
    {
        Name = "Camera";
     
    }
    public Camera(bool isLensIncluded , int megapixels)
    {
        Name = "Camera";
        IsLensIncluded =  isLensIncluded;
        Megapixels = megapixels;

    }

    public bool IsLensIncluded { get; set; }

    public int Megapixels { get; set; }
    

    public override string Description 
    { 
        get { return $"I am a Camera with id: {Id} I can make photos"; } 
        protected set { }
    }
}
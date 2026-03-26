namespace APBD_CW2.Models;

public abstract class User
{
    public int Id { get; set; }
    public abstract int MaxRentCount { get; set; }
    public abstract string Type { get; protected set; } 
    public abstract string FirstName { get; protected set; } 
    public abstract string LastName { get; protected set; } 
    public abstract int Balance { get; protected set; } 
    

}
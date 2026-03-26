namespace APBD_CW2.Models;

public class User
{
    public int Id { get; set; }
    public int MaxRentCount { get; set; } = 0;
    public string Type { get; protected set; } = "User";
    public string Name { get; protected set; } = "UserName";
    public string Surname { get; protected set; } = "UserSurname";
    public int Balance { get; protected set; } = 0;
    

}
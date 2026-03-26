using System.Text.Json.Serialization;
using APBD_CW2.Services;

namespace APBD_CW2.Models;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "UserType")]
[JsonDerivedType(typeof(Student), typeDiscriminator: "Student")]
[JsonDerivedType(typeof(Employee), typeDiscriminator: "Employee")]
public abstract class User
{
    public int Id { get; set; }
    [JsonIgnore]
    public abstract int MaxRentCount { get; set; }
    
    public abstract string Type { get; set; } 
    public abstract string FirstName { get; set; } 
    public abstract string LastName { get; set; } 
    public abstract int Balance { get; set; } 
    
    private static int nextUsersId = JsonReader.ReadJson("DataBase.json").Users.Max(x => x.Id) + 1;

    public User()
    {
        Id = nextUsersId;
    }

    
}
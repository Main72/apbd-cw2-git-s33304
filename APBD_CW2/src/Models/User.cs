using System.Text.Json.Serialization;

namespace APBD_CW2.Models;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "UserType")]
[JsonDerivedType(typeof(Student), typeDiscriminator: "Student")]
[JsonDerivedType(typeof(Employee), typeDiscriminator: "Employee")]
public abstract class User
{
    public int Id { get; set; }
    public abstract string Type { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    [JsonIgnore]
    public abstract int MaxRentCount { get; } 
    
    public User() { }
}
using System.Text.Json.Serialization;

namespace APBD_CW2.Models;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "UserType")]
[JsonDerivedType(typeof(Student), typeDiscriminator: "Student")]
[JsonDerivedType(typeof(Employee), typeDiscriminator: "Employee")]
public abstract class User
{
    public int Id { get; set; }
    [JsonIgnore]
    public abstract int MaxRentCount { get; set; }
    
    // Changed protected set to standard set so JSON can populate them!
    public abstract string Type { get; set; } 
    public abstract string FirstName { get; set; } 
    public abstract string LastName { get; set; } 
    public abstract int Balance { get; set; } 
}
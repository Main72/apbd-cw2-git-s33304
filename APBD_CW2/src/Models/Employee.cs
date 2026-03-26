namespace APBD_CW2.Models;

public class Employee : User
{
    public override string Type { get; set; } = "Employee";
    public override int MaxRentCount => 5; 

    public Employee() { }
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
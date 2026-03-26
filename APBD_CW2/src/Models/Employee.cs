namespace APBD_CW2.Models;

public class Employee:User
{
    public override int MaxRentCount { get; set; } = 5;
    public override string Type { get; protected set; } = "Employee";
    public override string FirstName { get; protected set; } = "undefined";
    public override string LastName { get; protected set; } = "undefined";
    public override int Balance { get; protected set; } = 100;

    public Employee(string name, string surname)
    {
        FirstName =  name;
        LastName = surname;
    }
}
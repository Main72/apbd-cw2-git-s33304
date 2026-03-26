namespace APBD_CW2.Models;

public class Employee:User
{
    public override int MaxRentCount { get; set; } = 5;
    public override string Type { get; set; } = "Employee";
    public override string FirstName { get; set; } = "undefined";
    public override string LastName { get; set; } = "undefined";
    public override int Balance { get; set; } = 100;

    public Employee() { }
    public Employee(string name, string surname)
    {
        FirstName =  name;
        LastName = surname;
    }
}
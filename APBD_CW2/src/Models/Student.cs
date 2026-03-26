namespace APBD_CW2.Models;

public class Student : User
{
    public override int MaxRentCount { get; set; } = 2;
    public override string Type { get; set; } = "Student"; 
    public override string FirstName { get; set; } = "undefined";
    public override string LastName { get; set; } = "undefined";
    public override int Balance { get; set; } = 100;


    public Student() { }

    public Student(string name, string surname)
    {
        FirstName = name;
        LastName = surname;
    }
}
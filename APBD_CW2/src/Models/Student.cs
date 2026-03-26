namespace APBD_CW2.Models;

public class Student : User
{
    public override string Type { get; set; } = "Student";
    public override int MaxRentCount => 2; 

    public Student() { }
    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
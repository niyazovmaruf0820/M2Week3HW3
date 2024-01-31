using Microsoft.VisualBasic;

namespace thetask;

public class Employee
{
    public int Id;
    public string FirstName;
    public string LastName;
    public int Age;
    public string PhoneNumber;
    public decimal Salary;
    public Employee(){}
    public Employee(string name, string surname)
    {
        FirstName = name;
        LastName = surname;
    }
    public int GetBirthYear()
    {
        return 2024 - Age;
    }
}

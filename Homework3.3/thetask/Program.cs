using thetask;
var employees = new List<Employee>()
{
    new Employee()
    {
        Id = 1,
        FirstName = "Alijon",
        LastName = "Zabirov",
        Age = 24,
        PhoneNumber = "881667007",
        Salary = 4000
    },
    new Employee()
    {
        Id = 2,
        FirstName = "Nurullo",
        LastName = "Sulaymonov",
        Age = 30,
        PhoneNumber = "908765432",
        Salary = 8000
    },
    new Employee()
    {
        Id = 3,
        FirstName = "Shodmon",
        LastName = "Inoyatzoda",
        Age = 26,
        PhoneNumber = "987009988",
        Salary = 7800
    },
};
var employees2 = new List<Employee>();
{
    new Employee()
    {
        Id = 4,
        FirstName = "Maruf",
        LastName = "Niyazov",
        Age = 15,
        PhoneNumber = "+992917782229",
        Salary = 10000
    };
    new Employee()
    {
        Id = 5,
        FirstName = "Rauf",
        LastName = "Niyazov",
        Age = 15,
        PhoneNumber = "+992917782229",
        Salary = 10000
    };
};
employees.AddRange(employees2);
List<Employee> employees3 = employees.OrderBy(e => e.Age).ToList();
employees3.RemoveAll(e => e.Age < 25);
List<Employee> employees4 = employees3.FindAll(e => e.Salary > 5000);
employees3.Remove(employees3.FirstOrDefault(e => e.Id == 3));
bool haveemployee = employees3.Exists(e => e.FirstName == "Jura");
if (haveemployee == false)
{
    var emp = new Employee();
    emp.Id = 6;
    emp.FirstName = "Jura";
    employees3.Insert(1, emp);
}
var employees5 = new List<Employee>();
{
    new Employee()
    {
        Id = 7,
        FirstName = "Orif",
        LastName = "Niyazov",
        Age = 15,
        PhoneNumber = "+992917782229",
        Salary = 10000
    };
    new Employee()
    {
        Id = 8,
        FirstName = "Hasan",
        LastName = "Niyazov",
        Age = 15,
        PhoneNumber = "+992917782229",
        Salary = 10000
    };
};
employees3.InsertRange(0, employees5);
List<Employee> employees6 = employees3.OrderByDescending(e => e.Age).ToList();

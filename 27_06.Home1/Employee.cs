using _25_06.Task2.Interfaces;

namespace _25_06.Task2;

public class Employee : IPerson
{
    private static int _id;
    public int Id { get; }
    public decimal Salary { get; set; }
    public string Name { get; set; }
    public byte Age { get; set; }

    public Employee(string name, byte age, decimal salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
        Id = ++_id;
    }


    public string ShowInfo()
    {
        return $"Name: {Name}, Age: {Age}, Id: {Id} , Salary: {Salary}";
    }
    public override string ToString()
    {
        return ShowInfo();
    }
}

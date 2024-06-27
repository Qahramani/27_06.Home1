using _25_06.Task2.Exceptions;

namespace _25_06.Task2;

public class Department
{
    public string Name { get; set; }
    public int EmployeeLimit { get; set; }

    public Employee[] employees;
    public Department(string name, int employeeLimit)
    {
        Name = name;
        EmployeeLimit = employeeLimit;
        employees = new Employee[0];
    }
    public Employee this[int index]
    {
        get => employees[index];
        set => employees[index] = value;
    }

    public void AddEmployee(Employee employee)
    {
        if (employees.Length >= EmployeeLimit)
            throw new CapacityLimitException("Limiti asirsiniz!");

        Array.Resize(ref employees, employees.Length + 1);
        employees[^1] = employee;


    }
}

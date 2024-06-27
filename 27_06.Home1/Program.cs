using _25_06.Task2.Exceptions;

namespace _25_06.Task2;

public class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Employee("Gunel", 20, 1200);
        Employee emp2 = new Employee("Samira", 20, 1500);
        Employee emp3 = new Employee("Canel", 24, 2000);

        Department dp = new Department("IT", 2);
        try
        {
            dp.AddEmployee(emp1);
            dp.AddEmployee(emp2);
            dp.AddEmployee(emp3);
        }
        catch (CapacityLimitException ex)
        {

            Console.WriteLine(ex.Message);
        }

        Console.WriteLine(dp[0]);
    }
}

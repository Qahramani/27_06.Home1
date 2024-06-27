namespace _25_06.Task2.Interfaces;

public interface IPerson
{
    string Name { get; set; }
    byte Age { get; set; }
    string ShowInfo();
}

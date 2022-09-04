namespace FactoryMethod;

public class Director : IEmployee
{
    public double GetSalary(double pricePerHour)
    {
        return 100 * pricePerHour;
    }

    public void GetTask()
    {
        Console.WriteLine($"Managing top-level tasks");
    }
}
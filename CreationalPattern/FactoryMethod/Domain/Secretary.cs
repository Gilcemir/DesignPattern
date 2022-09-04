namespace FactoryMethod;

public class Secretary : IEmployee
{
    public double GetSalary(double pricePerHour)
    {
        return 15 * pricePerHour;
    }

    public void GetTask()
    {
        Console.WriteLine($"Multi-Tasking!");
    }
}
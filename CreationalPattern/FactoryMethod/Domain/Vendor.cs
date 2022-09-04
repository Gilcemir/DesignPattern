namespace FactoryMethod;

public class Vendor : IEmployee
{
    public double GetSalary(double pricePerHour)
    {
        var commission = 100;
        return commission + 20 * pricePerHour;
    }

    public void GetTask()
    {
        Console.WriteLine($"Selling our products!");
    }
}
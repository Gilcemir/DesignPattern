namespace FactoryMethod;

public class Developer : IEmployee
{
    public double GetSalary(double pricePerHour)
    {
        return pricePerHour * 45;
    }

    public void GetTask()
    {
        Console.WriteLine($"Developing software");
    }
}
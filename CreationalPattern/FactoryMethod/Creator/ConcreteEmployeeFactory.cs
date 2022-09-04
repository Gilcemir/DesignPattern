namespace FactoryMethod;

public class ConcreteEmployeeFactory : EmployeeFactory
{
    public override IEmployee GetEmployee(Jobs job)
    {
        return job switch
        {
            Jobs.Developer => new Developer(),
            Jobs.Vendor => new Vendor(),
            Jobs.Secretary => new Secretary(),
            Jobs.Director => new Director(),
            _ => throw new ArgumentOutOfRangeException(nameof(job), job, null)
        };
    }
}
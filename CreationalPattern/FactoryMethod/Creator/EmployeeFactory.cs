namespace FactoryMethod;

public abstract class EmployeeFactory
{
    public abstract IEmployee GetEmployee(Jobs job);
}
namespace FactoryMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            var factory = new ConcreteEmployeeFactory();
            var employees = new List<IEmployee>();
            
            for(int i = 0; i < 100; i ++ )
            {
                employees.Add(factory.GetEmployee((Jobs)(new Random().Next(0, 4))));
            }

            foreach (var employee in employees)
            {
                var hoursWorked = new Random().Next(10, 41);
                Console.WriteLine($"Salary : {employee.GetSalary(hoursWorked)}");
                Console.WriteLine("---- Task -----");
                employee.GetTask();
            }

        }
    }
}
namespace DynamicPolymorphsim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            //partTimeEmployee.GetDetails();
            ////partTimeEmployee.GetPartTimeEmployeeDetails();
            //partTimeEmployee.DisplayDetails();
            ////partTimeEmployee.DisplayPartTimeEmployeeDetails();
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            //fullTimeEmployee.GetDetails();
            //fullTimeEmployee.DisplayDetails();

            // we want to call methods for child class objects thru paremt class object


            Employee employee;
            Console.WriteLine("which type of employee");
            int ch = byte.Parse(Console.ReadLine());
            if (ch == 1)
            {
                employee = new FullTimeEmployee();
            }
            else
            {
                employee = new PartTimeEmployee();
            }
            employee.GetDetails();
            employee.DisplayDetails();
        }
    }
}

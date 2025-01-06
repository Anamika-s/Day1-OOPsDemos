using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphsim
{
    internal class FullTimeEmployee : Employee
    {
        string dept;
        int salary;
        string manager;

        public FullTimeEmployee() : base() { }
            

        public FullTimeEmployee(int id, 
            string name, 
            string address , string dept, int salary, string manager)
            : base (id, name, address)
        {
            this.manager =  manager;
            this.salary = salary;
            this.dept = dept;
        }
        public override void GetDetails()
        //public void GetPartTimeEmployeeDetails()
        {
            base.GetDetails();
            Console.WriteLine("enter manager");
            manager = Console.ReadLine();
            Console.WriteLine("enter dept");
            dept = Console.ReadLine();
            Console.WriteLine("enter salary");
            salary= Int16.Parse(Console.ReadLine()); 
        }
        public override void DisplayDetails()
        //public void DisplayPartTimeEmployeeDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("manager is " + manager);
            Console.WriteLine("dept is " + dept);
            Console.WriteLine("salary is " + salary);
        }


    }
}

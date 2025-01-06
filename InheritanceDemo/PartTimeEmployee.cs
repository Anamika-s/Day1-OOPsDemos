using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class PartTimeEmployee : Employee
    {
        string projectName;
        int chargesPerDay;

        public PartTimeEmployee() : base() { }
            

        public PartTimeEmployee(int id, 
            string name, 
            string address , string projectName, int chargesPerDay)
            : base (id, name, address)
        {
            this.projectName = projectName;
            this.chargesPerDay = chargesPerDay;
        }
        public void GetDetails()
        //public void GetPartTimeEmployeeDetails()
        {   base.GetDetails();
            Console.WriteLine("enter projectName");
            projectName = Console.ReadLine();
            Console.WriteLine("enter chargesPerDay");
            chargesPerDay= Int16.Parse(Console.ReadLine()); 
        }
        public void DisplayDetails()
        //public void DisplayPartTimeEmployeeDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("projectName is " + projectName);
            Console.WriteLine("chargesPerDay are " + chargesPerDay);
        }


    }
}

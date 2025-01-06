using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphsim
{
    internal class Employee
    {
        int id;
        string name;
        string address;
        public Employee() { }

        public Employee(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public virtual void GetDetails()
        {
            Console.WriteLine("enter id");
            id= Int32.Parse(Console.ReadLine());
            Console.WriteLine("enyter nane");
            name = Console.ReadLine();
            Console.WriteLine("enter address");
            address = Console.ReadLine();
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine("ID is "+ id);
            Console.WriteLine("NAme is " + name);
            Console.WriteLine("Address is " + address);
        }
    }
}

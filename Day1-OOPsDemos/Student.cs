using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// int  , numbesrs , + - *
// Student , rn name batc markhs, GetDetails() DisplayDetails
namespace Day1_OOPsDemos
{
      class Student
    {
        int rn;
        string name;
        string batch;
        int marks;
        public void GetDetails()
        {
            Console.WriteLine("enter rn");
            rn = Byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter batch");
            batch = Console.ReadLine();
            Console.WriteLine("enter marks");
            marks = Byte.Parse(Console.ReadLine());

        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Rn is {rn}");
            Console.WriteLine($"Name is {name}");
            Console.WriteLine($"Batch is {batch}");
            Console.WriteLine($"Marks are {marks}");
        }
    }
}

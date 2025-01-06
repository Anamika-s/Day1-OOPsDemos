using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// int  , numbesrs , + - *
// Student , rn name batc markhs, GetDetails() DisplayDetails
namespace OopsDemo2
{
      class Student
    {
        readonly int rn;
        string name;
          static string batch="B001";
        int marks;
      public const string collegeName="ABC college";
        public static void BatchDetails()
        {
            //batch = "B001";
            Console.WriteLine("BATCH IS " + batch);
        }

        // static const
        static Student()
        {
            batch = "B019";
        }
        // def const
        public Student() { }
        // para constr
        public Student(int rn)
        {
            this.rn = rn;
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter marks");
            marks = Byte.Parse(Console.ReadLine());

        }

        // para const
        public Student(int rn, string name) 
        {
            this.rn = rn;
           this.name = name;
            Console.WriteLine("enter marks");
            marks = Byte.Parse(Console.ReadLine());

        }
        public Student(int rn, string name, int marks)
        {
            this.rn = rn;
            this.name = name;this.marks = marks;
        }

        public Student (Student student)
        {
            Console.WriteLine("enter rn");
            rn = Byte.Parse(Console.ReadLine());
            this.name = student.name;
            this.marks = student.marks;

        }
        public void GetDetails()
        {
            //Console.WriteLine("enter rn");
            //rn = Byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            //Console.WriteLine("enter batch");
            //batch = Console.ReadLine();
            Console.WriteLine("enter marks");
            marks = Byte.Parse(Console.ReadLine());

        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Rn is {rn}");
            Console.WriteLine($"Name is {name}");
            //Console.WriteLine($"Batch is {batch}");
            Console.WriteLine($"Marks are {marks}");
        }
    }
}

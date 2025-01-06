using System.Collections;

namespace Day1_OOPsDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Student student1 = new Student();
            // new keyword will do 2 things
            // 1. it allocates memory frm heap
            // 2. it calls const (def cons) to initialze all the attributes of the 
            // object to their def values
            student1.GetDetails();
            student1.DisplayDetails();

            Student student2 = new Student();
            student2.GetDetails();
            student2.DisplayDetails();

            Console.WriteLine("Array of objects");
            Student[] students = new Student[10];
            Console.WriteLine("enter details");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("enter details of student no " + (i+1));
                students[i] = new Student();
                students[i].GetDetails();
            }
            foreach (Student student in students)
            {if (student != null)
                {
                    Console.WriteLine("DETAILS ARE ");
                    student.DisplayDetails();
                }
            } 
            ArrayList list = new ArrayList();
            list.Add(student1);
            list.Add(student2);
            //list.Add(1);
            foreach (Student student in list)
            {
               
                    Console.WriteLine("DETAILS ARE ");
                    student.DisplayDetails();
                
            }
           
            List<Student> list2 = new List<Student>();
            list2.Add(student1);
            list2.Add(student2);
            //list2.Add(1);
            foreach (Student student in list2)
            {

                Console.WriteLine("DETAILS ARE ");
                student.DisplayDetails();

            }


        }
    }
}

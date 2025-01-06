namespace OopsDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("COLLEGE NAME IS " + Student.collegeName);
            Console.WriteLine("Batch is ");
            Student.BatchDetails();
            //Student.batch = "aaa";

            Student student1= new Student();
            student1.GetDetails();
            student1.DisplayDetails();
            Student student2= new Student();
            student2.GetDetails();
            student2.DisplayDetails();

            Student student3= new Student(1);
           student3.DisplayDetails();

            Student student4= new Student(2, "deepak");
            student4.DisplayDetails();

            Student student5 = new Student(3, "ajay", 90);
            student5.DisplayDetails();

            // this will call copy const
            Student student6 = new Student(student4);

        }
    }
}

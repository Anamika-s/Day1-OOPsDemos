using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritanceDemo
{
    internal class Student
    {
        //int id;
        //public int Id
        //{
        //    get 
        //    { 
        //        return id; 
        //    }
        //    set
        //    {
        //        id = value;
        //    }
        //}
        //private int id;

        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}
        public int Rn { get; set; }
        public string Name { get; set; }
        public string Batch { get; set; }
        public void GetDetails()
        {
            Console.WriteLine("enter Rn ");
            Rn = Byte.Parse(Console.ReadLine()); Console.WriteLine("enter name");
            Name = Console.ReadLine();
            Console.WriteLine("enter Batch");
            Batch = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            Console.WriteLine("RN is " + Rn);
            Console.WriteLine("NAme is " + Name);
            Console.WriteLine("Batch is " + Batch);
        }
        public Student()
        {

        }
        public Student(int Rn, string Name, string Batch)
        {
            this.Rn = Rn;
            this.Name = Name;
            this.Batch = Batch;
        }
    }

    class Sports : Student
    {
        string sportsName;
       protected  int score;
            public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("enter SportsName");
            sportsName = Console.ReadLine();
            Console.WriteLine("enter score");
            score = Byte.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("SportsName is " + sportsName);
            Console.WriteLine("score is " + score);
        }
        public Sports() : base() { }
        public Sports(int Rn, string Name, string Batch,
            string SportsName, int Score)
            : base(Rn, Name, Batch)
        {
            this.score = Score;
            this.sportsName = SportsName;
        }
    }
    class Test : Sports
    {
        int[] marks = [36, 77, 78, 56, 67];
        protected int totalMarks;
        public void CalculateTotalMarks()
        {
            foreach (var mark in marks)
            {
                totalMarks += mark;
            }
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Marks are ");
            foreach (var mark in marks)
                Console.Write( mark + " " );
            Console.WriteLine("Total Marks are " + totalMarks);
        }
    }
    class Result : Test
    {
        int totalScore;
        public void CalculateTotalScore()
        {
            totalScore = totalMarks + score;

        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Total Score is " + totalScore);
        }
    }
}


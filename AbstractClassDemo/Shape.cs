using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    abstract   class Shape
    {
        protected int dim1, dim2, area;
        abstract public void GetDimensions();
        abstract public void CalculateArea();
        public void DispalyArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }

    class Square : Shape
    {
        public override void CalculateArea()
        {
            area = dim1 * dim1;
        }

        public override void GetDimensions()
        {
            Console.WriteLine("enter value of side ");
            dim1 = byte.Parse (Console.ReadLine());
        }
    }

    class Rectangle : Shape
    {
        public override void CalculateArea()
        {
            area = dim1 * dim2;
        }

        public override void GetDimensions()
        {
            Console.WriteLine("enter value of l ");
            dim1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter value of w ");
            dim2 = byte.Parse(Console.ReadLine());

        }


    }
}

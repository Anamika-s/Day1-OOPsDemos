using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo1
{
    internal class Square
    {
        int side, area;
        public void GetDimensions()
        {
            Console.WriteLine("enter value of side ");
            side = byte.Parse(Console.ReadLine());  

        }
        public void CalculateArea()
        {
            area = side * side;
        }
        public void DispalyArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }

    internal class Rectangle
    {
        int l,w, area;
        public void GetDimensions()
        {
            Console.WriteLine("enter value of l ");
            l = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter value of w ");
            w = byte.Parse(Console.ReadLine());

        }
        public void CalculateArea()
        {
            area = l * w;
        }
        public void DispalyArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }
    internal class Triangle
    {
        int Base, height, area;
        public void GetDimensions()
        {
            Console.WriteLine("enter value of Base ");
            Base = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter value of height ");
            height = byte.Parse(Console.ReadLine());

        }
        public void CalculateArea()
        {
            area = (int).5* Base * height;
        }
        public void DispalyArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }
}

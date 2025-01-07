using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo2
{
    internal interface IShape
    {
        void GetDimensions();
        void CalculateArea();
        void DisplayArea();
    }

    class Sqaure : IShape
    {
        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void DisplayArea()
        {
            throw new NotImplementedException();
        }

        public void GetDimensions()
        {
            throw new NotImplementedException();
        }
    }

    class Rec : IShape
    {
        void IShape.CalculateArea()
        {
            throw new NotImplementedException();
        }

        void IShape.DisplayArea()
        {
            throw new NotImplementedException();
        }

        void IShape.GetDimensions()
        {
            throw new NotImplementedException();
        }
    }

    interface I1

    {
        void A();
        void B();
        void C();
    }
    interface I2
    {
        void A();
        void D();
        void E();
    }
    class Temp : I1, I2
    {
        public void A()
        {
            throw new NotImplementedException();
        }

        public void B()
        {
            throw new NotImplementedException();
        }

        public void C()
        {
            throw new NotImplementedException();
        }

        public void D()
        {
            throw new NotImplementedException();
        }

        public void E()
        {
            throw new NotImplementedException();
        }
    }
    class Temp1 : I1, I2
    {
        public void A()
        {
            throw new NotImplementedException();
        }

        public void B()
        {
            throw new NotImplementedException();
        }

        public void C()
        {
            throw new NotImplementedException();
        }

        void I2.A()
        {
            throw new NotImplementedException();
        }

        void I2.D()
        {
            throw new NotImplementedException();
        }

        void I2.E()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Figure square = new Square();

        }
    }
    abstract class A
    {
        public abstract double Method();
    }

    abstract class Figure : A
    {
        public abstract double GetArea();

        public virtual void Show() { }

        public void Show2() { }

        //public override double Method()
        //{
        //    throw new NotImplementedException();
        //}
    }

    class Square : Figure
    {
        private int a;
        private int b;

        public override double GetArea()
        {
            return a * b;
        }

        public override double Method()
        {
            throw new NotImplementedException();
        }
    }

    class Circle : Figure
    {
        private int radius;

        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double Method()
        {
            throw new NotImplementedException();
        }
        
    }
}

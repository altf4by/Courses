using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            object ob1 = new object();
            Object ob2 = new object();
            ob1 = ob2;

            Point p1 = new Point(2, 3);
            Point p2 = new Point(2, 3);

            Console.WriteLine(p1);

            Console.WriteLine(ob1.Equals(ob2));

            Console.WriteLine(ob1.GetHashCode());
            Console.WriteLine(ob2.GetHashCode());

            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());

            Console.WriteLine(Equals(p1,p2));
            Console.WriteLine(ReferenceEquals(p1,p2));

            Console.ReadKey();
        }
    }

    class Point
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }


        public override string ToString()
        {
            return string.Format("X = {0}, Y = {1}", X, Y);
        }

        public override bool Equals(object obj)
        {
            if (obj == null ||this.GetType()!=obj.GetType())
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            Point temp = (Point)obj;
            if (X == temp.X && Y == temp.Y)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return X^Y*255;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(4, 5, 7);
            Point b = new Point(7, 8, 9);

            Point c = a + b;
            Point d = a - b;
            Point e = -a;

            a.Show();
            b.Show();
            c.Show();
            d.Show();
            e.Show();
            a++.Show();
            a.Show();

            Console.ReadKey();

        }
    }
    class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }

        public Point()
        {
        }
        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void Show()
        {
            Console.WriteLine($"({X}, {Y}, {Z})");
        }

        public static Point operator +(Point left, Point right)
        {
            Point temp = new Point();
            temp.X = left.X + right.X;
            temp.Y = left.Y + right.Y;
            temp.Z = left.Z + right.Z;

            return temp;
        }
        public static Point operator -(Point left, Point right)
        {
            Point temp = new Point();
            temp.X = left.X - right.X;
            temp.Y = left.Y - right.Y;
            temp.Z = left.Z - right.Z;

            return temp;
        }
        public static Point operator -(Point left)
        {
            Point temp = new Point();
            temp.X = -left.X ;
            temp.Y = -left.Y ;
            temp.Z = -left.Z ;

            return temp;
        }
        public static Point operator ++(Point point)
        {
            return new Point(point.X + 1, point.Y + 1, point.Z + 1) ;
        }

    }
}

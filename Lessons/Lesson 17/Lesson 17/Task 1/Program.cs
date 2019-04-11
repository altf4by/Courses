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
            //int[] mas1 = { 1, 2, 3, 4, 5 };
            //int[] mas2 =(int[]) mas1.Clone();

            //Show(mas1);
            //Show(mas2);

            //mas2[2] = 777;

            //Console.WriteLine("After changes");

            //Show(mas1);
            //Show(mas2);
            Point[] p1 = { new Point(1, 2), new Point(3, 4) };
            Point[] p2 = (Point[])p1.Clone();

            Show(p1);
            Show(p2);

            p2[1].Y = 777;
            Console.WriteLine("After changes:");

            Show(p1);
            Show(p2);

            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());

            Console.ReadKey(true);
        }

        static void Show(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
                Console.Write("{0} ",mas[i]);
        }
        static void Show(Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
                Console.Write("[{0}] ", points[i]);

            Console.WriteLine();
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return string.Format("X:{0}, Y:{1}",X, Y);
        }
    }
}

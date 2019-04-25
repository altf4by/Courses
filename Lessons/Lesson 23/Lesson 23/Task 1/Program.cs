using System;
using System.Collections;
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
            int[] mas = { 1, 2, 3, 4, 5, 6, 7, 8, };

            for (int i = 0; i < mas.Length; i++)
                Console.Write(mas[i] + " ");

            Console.WriteLine();


            foreach (int item in mas)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            IEnumerator enumerator = mas.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.Write(enumerator.Current + " ");
            }
            enumerator.Reset();

            Console.WriteLine();

            PointList points = new PointList(5);
            points.Add(new Point(1, 2));
            points.Add(new Point(3, 4));
            points.Add(new Point(5, 6));

            foreach (Point point in points)
            {
                Console.WriteLine(point + " ");

            }


            Console.ReadKey();

        }
    }

    class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1}", X.ToString(), Y.ToString());
        }
    }

    class PointList
    {
        private Point[] points;

        public int Count { get; set; }

        public int Capacity { get { return points.Length; } }


        public PointList(int size)
        {
            points = new Point[size];
        }

        public void Add(Point point)
        {
            if (Count == Capacity)
                return;
            points[Count++] = point;
        }

        public Point this[int index]
        {
            get { return points[index]; }
            set
            {
                if (index < Count && index >= 0)
                    points[index] = value;
            }
        }

        public IEnumerator<Point> GetEnumerator()
        {
            int pointer = 0;

            while (pointer <= Count)
            {
                yield return points[++pointer];
            }

        }
    }
}

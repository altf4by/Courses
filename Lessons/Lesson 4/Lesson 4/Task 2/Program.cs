using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Method3(5,1,true);
            int y = 10;
            int result = Sum(5,y);
            Console.WriteLine(result);
            BBB(y:45,str:"asda");

            Console.ReadKey();
        }

        static void Method3(int x, int d, bool isLeft)
        {
            int result = isLeft ? x<<d : x>>d;
            Console.WriteLine(result);
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
        static double Sum(double a, double b)
        {
            return a + b;
        }
        static double Sum(double a, double b, double c)
        {
            return a + b+c;
        }
        static double MMM(int x)
        {
            if (x > 10)
                return Math.Pow(x, 3);
            else return x;
        }
        static void NNN(int y)
        {
            if (y==90)
            {
                return;
            }
            Console.WriteLine(y);
        }
        static void BBB(string str, int y, int r=89) { }

    }
}

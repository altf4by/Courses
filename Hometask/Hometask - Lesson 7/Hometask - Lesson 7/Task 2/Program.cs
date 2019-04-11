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
            double x1, x2, x3, y1, y2, y3;

            GetInput(out x1, out y1, "first");
            GetInput(out x2, out y2, "second");
            GetInput(out x3, out y3, "third");

            double sideA = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double sideB = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double sideC = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            double halfPerimetr = (sideA + sideB + sideC)/2;
            Console.WriteLine($"Perimetr is {halfPerimetr*2}\n");

            double square = Math.Sqrt((halfPerimetr * (halfPerimetr - sideA)*(halfPerimetr-sideB)*(halfPerimetr-sideC)));
            Console.WriteLine($"Square is {square}\n");

            Console.ReadKey(true);
        }

        static void GetInput(out double x, out double y, string numberOfPoint)
        {
            Console.Write($"Enter X value of the {numberOfPoint} point: ");
            x = double.Parse(Console.ReadLine());
            Console.Write($"Enter Y value of the {numberOfPoint} point: ");
            y = double.Parse(Console.ReadLine());
        }
    }
}

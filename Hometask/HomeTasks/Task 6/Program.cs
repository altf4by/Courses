using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Please enter у: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine($"Your point ({x};{y}) is in {(x>0?((y>0)?"1st":"4th"):y>0?"2nd":"3rd")} quarter");
            Console.ReadKey();
        }
    }
}

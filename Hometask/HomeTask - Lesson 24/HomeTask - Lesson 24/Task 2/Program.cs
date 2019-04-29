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
            Year year = new Year();

            Console.WriteLine("Display month by position:\n");

            Console.WriteLine(year.GetMonthByPosition(1));
            Console.WriteLine(year.GetMonthByPosition(2));
            Console.WriteLine(year.GetMonthByPosition(12));

            Console.WriteLine("\nDisplay months by days:\n");

            foreach (Month month in year.GetMonthsByDays(31))
                Console.WriteLine(month);

            Console.ReadKey();
        }
    }
}

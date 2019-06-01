using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 456, 78, 234, 789, 4, 67, 78 };

            var query = from a in mas
                        where a > 100
                        select a;

            var query2 = mas.Where(a => a > 100).Select(a => a);

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

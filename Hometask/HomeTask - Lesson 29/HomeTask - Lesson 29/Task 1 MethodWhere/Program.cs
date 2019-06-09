using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_MethodWhere
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lsit = new List<int> { 1, 2, 3, 4, 5, 6 };

            var l = lsit.Where(i => i % 2 == 0);
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}

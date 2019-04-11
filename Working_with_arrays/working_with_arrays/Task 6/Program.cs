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
            string str = "sada sd s, sds , sd/sdsd. dsds.";
            string[] mass = str.Split(" ,./".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
            foreach (string st in mass)
                Console.WriteLine(st);

            Console.ReadKey();
        }
    }
}

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
            Console.WriteLine("sadasda");
            char ch = Console.ReadKey().KeyChar;
            if (char.IsControl(ch))
            {
                Console.WriteLine("Control Key");
            }
            Console.ReadKey(true);
        }    
    }
}

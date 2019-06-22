using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void WriteSecond()
        {
            while (true)
                Console.WriteLine(new string(' ', 10) + "Secondary");
        }

        static void Main()
        {
            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            thread.Start();

            while (true)
            {
                Console.WriteLine("Primary");
            }

            Console.ReadKey();
        }
    }

}

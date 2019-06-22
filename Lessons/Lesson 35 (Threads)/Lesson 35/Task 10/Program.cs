using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        private static void Function()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            while (true)
            {
                try
                {
                    Thread.Sleep(10);
                    Console.Write(".");
                }
                catch (ThreadAbortException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nThreadAbortException");

                    for (int i = 0; i < 160; i++)
                    {
                        Thread.Sleep(20);
                        Console.Write(".");
                    }

                    Console.ForegroundColor = ConsoleColor.Green;

                    Thread.ResetAbort();
                }

            }
        }

        static void Main()
        {
            Thread thread = new Thread(new ThreadStart(Function));
            thread.Start();

            Thread.Sleep(2000);

            thread.Abort();

            thread.Join();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n" + new string('_', 80));

            Console.ReadKey();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void WriteSecond()
        {
            Thread thread = Thread.CurrentThread;

            thread.Name = "Secondary";

            Console.WriteLine("ID потока {0}: {1}", thread.Name, thread.GetHashCode());

            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(new string(' ', 15) + thread.Name + " " + counter);
                Thread.Sleep(1000);
            }
        }

        static void Main()
        {
            Thread primaryThread = Thread.CurrentThread;

            primaryThread.Name = "Primary";

            Console.WriteLine("ID потока {0}: {1}", primaryThread.Name, primaryThread.GetHashCode());

            Thread secondaryThread = new Thread(WriteSecond);
            secondaryThread.Start();

            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(primaryThread.Name + " " + counter);
                Thread.Sleep(1500);
            }

            Console.ReadKey();
        }
    }

}

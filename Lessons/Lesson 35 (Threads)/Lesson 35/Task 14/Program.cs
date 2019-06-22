using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_14
{
    class Program
    {
        static private long counter;
        static private readonly Random random = new Random();

        private static void Function()
        {
            Interlocked.Increment(ref counter);

            try
            {
                int time = random.Next(1000, 12000);
                Thread.Sleep(time);
            }
            finally
            {
                Interlocked.Decrement(ref counter);
            }
        }

        private static void Report()
        {
            while (true)
            {
                long number = Interlocked.Read(ref counter);

                Console.WriteLine("{0} поток(ов) активно.", number);
                Thread.Sleep(100);
            }
        }

        static void Main()
        {
            var reporter = new Thread(Report) { IsBackground = true };
            reporter.Start();

            var threads = new Thread[150];

            for (uint i = 0; i < 150; ++i)
            {
                threads[i] = new Thread(Function);
                threads[i].Start();
            }

            Thread.Sleep(15000);

        }
    }

}

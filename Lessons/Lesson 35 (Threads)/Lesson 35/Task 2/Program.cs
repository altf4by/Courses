using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void WriteSecond()
        {
            int counter = 0;

            while (counter < 10)
            {
                Console.WriteLine("Thread Id {0}, counter = {1}", Thread.CurrentThread.GetHashCode(), counter);
                counter++;
            }
        }

        static void Main()
        {
            Console.WriteLine("Thread Id {0}", Thread.CurrentThread.GetHashCode());
            Thread thread = new Thread(WriteSecond);//техника предположения делегата
            thread.Start();

            WriteSecond();

            Console.ReadKey();
        }
    }

}

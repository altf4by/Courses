using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void WriteSecond(object argument)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(argument);
                Thread.Sleep(1000);
            }
        }

        static void Main()
        {
            ParameterizedThreadStart writeSecond = new ParameterizedThreadStart(WriteSecond);
            int y = 90;
            DateTime date = DateTime.Now;
            Thread thread = new Thread((o)=> 
            {
                for (int i = 0; i < 10; i++)
                {
                Console.WriteLine($"{y.ToString()} - {date.ToString()}");
                    Thread.Sleep(1000);
                }
            });
            thread.Start("Hello");

            Thread.Sleep(500);

            Console.ReadKey();
        }
    }

}

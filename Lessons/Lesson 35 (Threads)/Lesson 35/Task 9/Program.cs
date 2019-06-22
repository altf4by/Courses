using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        [ThreadStatic]
        public static int counter;

        public static void Method()
        {
            if (counter < 100)
            {
                counter++;
                Console.WriteLine(counter + " - СТАРТ --- " + Thread.CurrentThread.GetHashCode());
                var thread = new Thread(Method);
                thread.Start();
                thread.Join();
            }

            Console.WriteLine("Поток {0} завершился.", Thread.CurrentThread.GetHashCode());
        }

        static void Main()
        {
            var thread = new Thread(Method);
            thread.Start();
            thread.Join();

            Console.WriteLine("Основной поток завершил работу...");

            Console.ReadKey();
        }
    }

}

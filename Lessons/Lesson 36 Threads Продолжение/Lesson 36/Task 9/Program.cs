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
        static readonly AutoResetEvent auto = new AutoResetEvent(false);
        static void Main()
        {
            Console.WriteLine("Нажмите на любую клавишу для перевода AutoResetEvent в сигнальное состояние.\n");

            var thread2 = new Thread(Function1);
            thread2.Start();

            var thread = new Thread(Function1);
            thread.Start();

            Console.ReadKey();
            auto.Set();

            Console.ReadKey();
            auto.Set();

            Console.ReadKey();
        }

        static void Function1()
        {
            Console.WriteLine("Красный свет");
            auto.WaitOne();
            Console.WriteLine("Желтый");
            auto.WaitOne();
            Console.WriteLine("Зеленый");
        }
    }

}

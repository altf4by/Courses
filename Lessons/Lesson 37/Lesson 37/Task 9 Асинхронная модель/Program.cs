using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_9_Асинхронная_модель
{
    class Program
    {
        static void Main()
        {
            var myDelegate = new Func<int, int, int>(Add);

            IAsyncResult asyncResult = myDelegate.BeginInvoke(1, 2, null, null);

            int result = myDelegate.EndInvoke(asyncResult);

            Console.WriteLine("Результат = " + result);

            Console.ReadKey();
        }

        static int Add(int a, int b)
        {
            Thread.Sleep(2000);
            return a + b;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_10_Асинхронная_модель
{
    class Program
    {
        static void Main()
        {
            var myDelegate = new Func<int, int, int>(Add);

            IAsyncResult asyncResult = myDelegate.BeginInvoke(1, 2, null, null);

            Console.WriteLine("Асинхронный метод запущен. Метод Main продолжает работать.");
            Console.WriteLine("Метод Main ожидает завершения асинхронной задачи.");

            Console.WriteLine(asyncResult.AsyncWaitHandle.GetType());

            asyncResult.AsyncWaitHandle.WaitOne();
            Console.WriteLine("Асинхронный метод завершен.");

            int result = myDelegate.EndInvoke(asyncResult);

            asyncResult.AsyncWaitHandle.Close();

            Console.WriteLine("Результат = " + result);

            Console.ReadKey();
        }

        static int Add(int a, int b)
        {
            Thread.Sleep(3000);
            return a + b;
        }
    }

}

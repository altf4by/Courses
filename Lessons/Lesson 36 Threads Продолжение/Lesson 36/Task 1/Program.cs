using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };

            MyThread mtl = new MyThread("Поток #1", a);
            MyThread mt2 = new MyThread("Поток #2", a);

            mtl.thrd.Join();
            mt2.thrd.Join();

            Console.ReadKey();
        }
    }

    class SumArray
    {
        int sum;
        public int sumlt(int[] nums)
        {
            sum = 0; // Начальное значение суммы.
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                Console.WriteLine(
                "Промежуточная сумма для потока " +
                Thread.CurrentThread.Name +
                " равна " + sum);
            }
            return sum;
        }
    }

    class MyThread
    {
        public Thread thrd;
        int[] a;
        int answer;

        /* Создаем один объект класса SumArray для всех
        экземпляров класса MyThread. */
        static SumArray sa = new SumArray();

        public MyThread(string name, int[] nums)
        {
            a = nums;
            thrd = new Thread(new ThreadStart(this.run));
            thrd.Name = name;
            thrd.Start();
        }

        void run()
        {
            Console.WriteLine(thrd.Name + " стартовал.");

            // Инструкция lock содержит вызов метода sumlt().
            lock (sa) answer = sa.sumlt(a);

            Console.WriteLine("Сумма для потока " + thrd.Name +
                                " равна " + answer);

            Console.WriteLine(thrd.Name + " завершен.");
        }
    }

}

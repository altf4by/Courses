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
        static void Main(string[] args)
        {
            int size = 20;
            char[] symbs = new char[size];
            for (int k = 0; k < symbs.Length; k++)
            {
                symbs[k] = '*';
                Console.Write("|" + symbs[k]);
            }
            Console.WriteLine("|");
            int first = 0, second = symbs.Length - 1;
            Thread A, B;

            A = new Thread(() =>
            {
                char start = 'Я';
                while (true)
                {
                    if (second > first)
                    {
                        symbs[second] = start;
                        start--;
                        second--;
                        Thread.Sleep(100);
                    }
                    else
                        Thread.CurrentThread.Abort();
                }
            });


            B = new Thread(() =>
            {
                char start = 'A';

                while (true)
                {
                    if (first < second)
                    {
                        symbs[first] = start;
                        start++;
                        second++;
                        Thread.Sleep(100);
                    }
                    else Thread.CurrentThread.Abort();
                }
            });

            A.Start();
            B.Start();

            if (A.IsAlive) A.Join();

            if (B.IsAlive) B.Join();

            for (int i = 0; i < symbs.Length - 1; i++)
                Console.Write("|" + symbs[i]);
            Console.Write("|");

            Console.ReadKey();
        }



    }
}

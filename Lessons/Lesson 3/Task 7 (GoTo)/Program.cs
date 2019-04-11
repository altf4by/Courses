using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7__GoTo_
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                if (i==5)
                {
                    goto Metka;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Hello");
            Metka: Console.WriteLine("In metka");
            Console.ReadLine();

        }
    }
}

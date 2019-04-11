using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 0; i < 5; i++)
            //{
            //    Method();
            //}
            while (true)
            {
                string phrase = Console.ReadLine();
                if (phrase == "exit")
                    break;
                Method2(phrase);
            }

            

            Console.ReadKey();
        }

        static void Method()
        {
            Console.WriteLine("Hello world");
        }
        static void Method2(string message)
        {
            Console.WriteLine(message);
        }

    }
}

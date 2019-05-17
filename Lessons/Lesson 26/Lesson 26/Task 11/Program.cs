using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    delegate void MyDelegate(int argument);

    class Program
    {
        static void Main()
        {
            MyDelegate my = null;

            my = (int i) =>
            {
                i--;
                Console.WriteLine("Begin {0}", i);

                if (i > 0)
                {
                    my(i);
                }

                Console.WriteLine("End {0}", i);
            };

            my(3);

            Console.ReadKey();
        }
    }

}

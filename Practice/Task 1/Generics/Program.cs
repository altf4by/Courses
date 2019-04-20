using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 10;
            int b1 = 20;

            string a2 = "Hello ";
            string b2 = "World!";


            Console.WriteLine("before swap: {0}, {1}", a1,b1);
            Console.WriteLine("before swap: {0}, {1}", a2, b2);

            Swap<int>(ref a1, ref b1);
            //Swap<string>(ref a2, ref b2);


            //Console.WriteLine("after swap: {0}, {1}", a1, b1);
            //Console.WriteLine("after swap: {0}, {1}", a2, b2);


        }

        static void Swap <T>(ref T a, ref T b) where T: struct
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}

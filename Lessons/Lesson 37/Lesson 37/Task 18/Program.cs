using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_18
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder stringBuilder = new StringBuilder("Hello");

            Console.WriteLine(stringBuilder.Capacity);
            Console.WriteLine(stringBuilder.Length);



            stringBuilder.Append("Hello");
            Console.WriteLine(stringBuilder.ToString());

            stringBuilder.AppendLine("Hello");
            Console.WriteLine(stringBuilder.ToString());


            stringBuilder.AppendFormat("Hello {0}",6);
            Console.WriteLine(stringBuilder.ToString());

            //string str = "Hello";
            //string str2 = str = str.Replace('l', 'w');

            //Console.WriteLine(str);
            //Console.WriteLine(str2);

            Console.ReadKey();
        }
    }
}

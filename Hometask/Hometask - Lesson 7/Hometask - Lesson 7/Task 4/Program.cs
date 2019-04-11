using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your string: ");
            char[] str = Console.ReadLine().ToCharArray();
            char[] convertedStr = new char[str.Length];
            Console.WriteLine((int)str[0]);

            Console.WriteLine("Converted string:");
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 65 && str[i] < 97) || (str[i] >= 1040 && str[i] < 1072))
                    convertedStr[i] = Convert.ToChar(str[i] + 32);
                else
                    if ((str[i] >= 97 && str[i] <= 129) || (str[i] >= 1072 && str[i] <= 1104))
                    convertedStr[i] = Convert.ToChar(str[i] - 32);
                    else
                    convertedStr[i] = Convert.ToChar(str[i]);
                Console.Write(convertedStr[i]);
            }

            Console.ReadKey(true);
        }
    }
}

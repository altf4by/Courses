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
            char[] array = new char[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (char)('B' + i);
                if (array[i]=='E'| array[i] == 'I')
                {
                    array[i] = (char)('B' + 2*i);
                }
                Console.Write($"{array[i]} ");
            }

 
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();

            char[] array = str.ToCharArray();
            bool isPalindrom = false;
            int counter = 0;
            
            do
            {
                if (array[counter]==array[array.Length-1-counter])
                {
                    isPalindrom = true;
                    counter++;
                }
                else
                {
                    isPalindrom = false;
                    break;
                }

            } while (counter!=array.Length/2);

            Console.WriteLine($"Введенная строка{(isPalindrom?"":" НЕ")} палиндром.");
            Console.ReadKey(true);
        }
    }
}

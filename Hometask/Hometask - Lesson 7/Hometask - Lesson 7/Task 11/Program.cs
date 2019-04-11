using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальный текст: ");
            string str = Console.ReadLine();

            Console.Write("Введите текст, который хотим заменить: ");
            string strSearch = Console.ReadLine();

            if (str.Contains(strSearch))
            {
                Console.Write("Введите текст, на что хотим заменить: ");
                string strChange = Console.ReadLine();

                string strNew = str.Replace(strSearch, strChange);
                Console.Write($"Текст после замены: {strNew}");
            }
            else
            {
                Console.WriteLine("Такого текста нет в строке.");
            }

            



            Console.ReadKey(true);
        }
    }
}

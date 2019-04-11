using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "ПолиморфизмНаследованиеИнкапсуляция";
            string str2 = "АБВГДЕЖЗИКЛМН";

            Console.WriteLine("Первое вхождение символа \'Н\': " +
                                                        str1.IndexOf('Н'));
            Console.WriteLine("Первое вхождение подстроки \"Наследование\" : " +
                                                        str1.IndexOf("Наследование"));
            Console.WriteLine("Последнее вхождение символа \'И\': " +
                                                        str1.LastIndexOf('И'));
            Console.WriteLine("Последнее вхождение любого из символов строки" +
                                                            "\"АБВГДЕЖЗИКЛМН\" : " +
                                                str1.LastIndexOfAny(str2.ToCharArray()));
            Console.WriteLine("Подстрока начиная с 11 символа по 23-й : " +
                                                        str1.Substring(11, 12));


            Console.ReadLine();
        }

    }
}

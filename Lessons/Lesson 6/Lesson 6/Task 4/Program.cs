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
            string str1 = "Простая строка";
            string str2 = "Строка";
            string str3 = "строка";
            string[] strArr = { "ШАГ", "шагаем", "бежим", "ем", "Играем" };

            Console.WriteLine("\"" + str1 + "\" equal \"" + str2 + "\" : " +
                                                                str1.Equals(str2));
            Console.WriteLine("\"" + str2 + "\" == \"Строка\" : " +
                                                                (str2 == "Строка"));
            Console.WriteLine("\"" + str2 + "\".CompareTo(\"" + str3 +
                                                        "\") : " + str2.CompareTo(str3));

            Console.WriteLine("Сравнение без учета регистра:");
            Console.WriteLine("\"" + str2 + "\" equal \"" + str3 + "\" : " +
                  str2.Equals(str3, StringComparison.CurrentCultureIgnoreCase));

            Console.Write("Слова начинающиеся на \"шаг\": ");
            foreach (string s in strArr)
                if (s.StartsWith("шаг", StringComparison.CurrentCultureIgnoreCase))
                    Console.Write(s + " ");
            Console.Write("\nСлова заканчивающиеся на \"ем\": ");
            foreach (string s in strArr)
                if (s.EndsWith("ем", StringComparison.CurrentCultureIgnoreCase))
                    Console.Write(s + " ");
            Console.WriteLine();


            Console.ReadLine();
        }

    }
}

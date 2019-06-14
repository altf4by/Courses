using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_2_Regular_Expressions_2
{
    class Program
    {
        static void Main()
        {
            string pattern = @"\d+";

            var regex = new Regex(pattern);

            var array = new[] { "test", "123", "test123test", "123test", "test123" };

            foreach (string element in array)
            {
                Console.WriteLine(
                    regex.IsMatch(element)
                        ? "Строка \"{0}\" соответствует шаблону \"{1}\""
                        : "Строка \"{0}\" НЕ соответствует шаблону \"{1}\"", element, pattern);

                Console.WriteLine(new string('-', 50));
            }

            Console.WriteLine("\n\n");

            while (true)
            {
                Console.WriteLine("Введите строку для сравнения: ");

                string input = Console.ReadLine();

                if (input == "exit")
                    break;

                Console.WriteLine(
                    input != null && regex.IsMatch(input)
                        ? "Строка \"{0}\" соответствует шаблону \"{1}\""
                        : "Строка \"{0}\" НЕ соответствует шаблону \"{1}\"", input, pattern);

                Console.WriteLine(new string('-', 50));
            }
        }
    }

}

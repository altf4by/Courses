using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_3_Regular_Expressions___3
{
    class Program
    {
        static void Main()
        {
            string pattern;

            //  pattern = @"\d+";     // "123", "test123", "123test", "te123st", "4556yyy789"

            //  pattern = @"^\d+";  // "123", "123test", "4556yyy789"

            //  pattern = @"\d+$";  // "123", "test123", "4556yyy789"

            pattern = @"^\d*\D+\d+$"; // "1j23"


            var regex = new Regex(pattern);

            var array = new[] { "test", "123", "test123", "123test", "te123st", "4556yyy789" };

            foreach (String element in array)
            {
                Console.WriteLine(
                    regex.IsMatch(element)
                        ? "Строка \"{0}\" соответствует шаблону \"{1}\""
                        : "Строка \"{0}\" НЕ соответствует шаблону \"{1}\"", element, pattern);

                Console.WriteLine(new string('-', 50));
            }

            Console.ReadKey();
        }
    }

}

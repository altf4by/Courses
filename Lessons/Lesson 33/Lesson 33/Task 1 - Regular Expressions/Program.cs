using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1___Regular_Expressions
{
    class Program
    {
        static void Main()
        {
            const string pattern = @"\d";

            var regex = new Regex(pattern);

            while (true)
            {
                string @string = Console.ReadKey().KeyChar.ToString();

                if (@string == " ")
                    break;

                bool success = regex.IsMatch(@string);

                Console.WriteLine(success ?
                                          " соответствует шаблону \"{0}\"" :
                                          " НЕ соответствует шаблону \"{0}\"",
                                  pattern);
            }
        }
    }

}

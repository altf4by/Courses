using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_4_Regular_Expressions_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Regex.Replace("test123aaa4x5x6bbb789ccc",
                                            @"\d+",
                                             " "));

            Console.WriteLine(Regex.Replace("test123aaa4x5x6bbb789ccc",
                                           @"\d",
                                            " "));
            Console.WriteLine(Regex.Replace("02/05/1982",
                                           @"(?<месяц>\d{1,2})/(?<день>\d{1,2})\/(?<год>\d{2,4})",
                                                                                     "${день}-${месяц}-${год}"));
            Console.WriteLine(Regex.Replace(@"test123firststr456secondstr",
                                            @"test(?<var1>\d+)firststr(?<var2>\d+)secondstr",
                                            @"test${var2}firststr${var1}secondstr"));

            Console.WriteLine(Regex.Replace("5 is less than 10",
                                            @"\d",
                                            m => (int.Parse(m.Value) + 1).ToString()));

            Console.ReadKey();
        }
    }

}

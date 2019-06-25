﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_7_Regular_Expressions_7
{
    class Program
    {
        static void Main()
        {
            string input = "";
            input += "<a href='http://bsystem.com'>Home-page</a>";
            input += "<a href='http://google.com'>Search</a>";
            input += "<a href='https://ya.ru'>Yandex</a>";
            input += "<a href='https://yandex.ru'>Yandex Full</a>";
            input += "<a href='http://microsoft.com'>Microsoft</a>";

            var regex = new Regex(@"href='(?<link>\S+)'>(?<text>\S+)</a>");
            Console.WriteLine(input);

            for (var m = regex.Match(input); m.Success; m = m.NextMatch())
            {
                Console.WriteLine("ССЫЛКА: {0,-25} на: {1,-4} позиции с именем: {2}", m.Groups["link"],
                                                                                      m.Groups["link"].Index,
                                                                                      m.Groups["text"]);
            }

            Console.WriteLine(new string('-', 25));

            foreach (Match m in regex.Matches(input))
            {
                Console.WriteLine("ССЫЛКА: {0,-25} на: {1,-4} позиции с именем: {2}", m.Groups["link"],
                                  m.Groups["link"].Index,
                                  m.Groups["text"]);
            }

            Console.WriteLine(new string('-', 20));
            var htmlQuery = from Match m in regex.Matches(input)
                            where m.Groups["link"].Value.StartsWith("https")
                            select m;


            foreach (var m in htmlQuery)
            {
                Console.WriteLine("ССЫЛКА: {0,-25} на: {1,-4} позиции с именем: {2}", m.Groups["link"],
                                 m.Groups["link"].Index,
                                 m.Groups["text"]);
            }
            Console.ReadKey();
        }
    }

}

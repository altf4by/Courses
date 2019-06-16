using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_1__Login_and_password_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to website");

            string patternLogin = @"^[a-z]+$";
            var regLog = new Regex(patternLogin);


            string patternPassword = @"^[a-z0-9]+$";
            var regPas = new Regex(patternPassword);

            while (true)
            {
                Console.WriteLine("Enter Your LOGIN:");
                string login = Console.ReadLine();

                if (!regLog.IsMatch(login))
                {
                    Console.WriteLine("Your input is incorrect. Press any key");
                    Console.ReadKey(true);
                    ClearLine();
                }
                else
                    break;
            }

            while (true)
            {
                Console.WriteLine("Enter Your PASSWORD:");
                string password = Console.ReadLine();

                if (!regPas.IsMatch(password))
                {
                    Console.WriteLine("Your input is incorrect. Press any key");
                    Console.ReadKey(true);
                    ClearLine();
                }
                else break;
            }

            Console.WriteLine("You enter!!!!");

            Console.ReadKey();
        }

        static void ClearLine()
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 2);

            }
            Console.WriteLine();
        }
    }
}

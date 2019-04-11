using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Peter";
            string password = "parker";

            Console.WriteLine("Please, enter your login");

            string nameForCheck = Console.ReadLine();
            if (name==Console.ReadLine())
            {
                Console.WriteLine("Please, enter your password");
                if (password==Console.ReadLine())
                    Console.WriteLine($"Hello, {name}");
                else
                    Console.WriteLine("Good Bye");
            }
            else
            {
                Console.WriteLine("Good Bye");
            }


            Console.ReadKey();

        }
    }
}

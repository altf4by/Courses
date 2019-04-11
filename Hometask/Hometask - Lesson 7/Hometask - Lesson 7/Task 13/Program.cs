using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type the sentence: ");
            string str = Console.ReadLine();

            string[] wordsArray = str.Split(" ,!.".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"There are {wordsArray.Length} words in the sentence.");
            Console.ReadKey(true);
        }
    }
}

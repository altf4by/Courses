using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваш текст: ");
            string str = Console.ReadLine();

            string[] wordsArray = str.Split(" ,!.".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            int counter = 0;
            for (int i = 0; i < wordsArray.Length; i++)
            {
                if (wordsArray[i].EndsWith("у") ||
                    wordsArray[i].EndsWith("е") ||
                    wordsArray[i].EndsWith("ы") ||
                    wordsArray[i].EndsWith("а") ||
                    wordsArray[i].EndsWith("о") ||
                    wordsArray[i].EndsWith("э") ||
                    wordsArray[i].EndsWith("я") ||
                    wordsArray[i].EndsWith("и") ||
                    wordsArray[i].EndsWith("ю"))
                    counter++;
            }


            Console.WriteLine($"В введенном тексте {counter} слов, заканчивающихся на гласные.");
            Console.ReadKey(true);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите число от 100 до 999: ");
                string number = Console.ReadLine();
                if (int.Parse(number)>99&& int.Parse(number) <1000)
                {
                    Console.Write("Ваше число прописью: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    int[] array = new int[number.Length];
                    for (int i = 0; i < number.Length; i++)
                        array[i] = int.Parse(number[i].ToString());

                    switch (array[0])
                    {
                        case 1: Console.Write("Сто "); break;
                        case 2: Console.Write("Двести "); break;
                        case 3: Console.Write("Триста "); break;
                        case 4: Console.Write("Четыреста "); break;
                        case 5: Console.Write("Пятьсот "); break;
                        case 6: Console.Write("Шестьсот "); break;
                        case 7: Console.Write("Семьсот "); break;
                        case 8: Console.Write("Восемьсот "); break;
                        case 9: Console.Write("Девятьсот "); break;
                    }

                    switch (array[1])
                    {
                        case 1:
                            switch (array[2])
                            {
                                case 1: Console.Write("одиннадцать"); break;
                                case 2: Console.Write("двенадцать"); break;
                                case 3: Console.Write("тринадцать"); break;
                                case 4: Console.Write("четырнадцать"); break;
                                case 5: Console.Write("пятнадцать"); break;
                                case 6: Console.Write("шестнадцать"); break;
                                case 7: Console.Write("семнадцать"); break;
                                case 8: Console.Write("восемнадцать"); break;
                                case 9: Console.Write("девятнадцать"); break;
                                case 0: Console.Write("десять"); break;

                            }
                            break;
                        case 2: Console.Write("двадцать "); break;
                        case 3: Console.Write("тридцать "); break;
                        case 4: Console.Write("сорок "); break;
                        case 5: Console.Write("пятьдесят "); break;
                        case 6: Console.Write("шестьдесят "); break;
                        case 7: Console.Write("семьдесят "); break;
                        case 8: Console.Write("восемьдесят "); break;
                        case 9: Console.Write("девяносто "); break;
                    }

                    if (array[1] != 1)
                    {
                        switch (array[2])
                        {
                            case 1: Console.Write("один"); break;
                            case 2: Console.Write("два"); break;
                            case 3: Console.Write("три"); break;
                            case 4: Console.Write("четыре"); break;
                            case 5: Console.Write("пять"); break;
                            case 6: Console.Write("шесть"); break;
                            case 7: Console.Write("семь"); break;
                            case 8: Console.Write("восемь"); break;
                            case 9: Console.Write("девять"); break;
                        }
                    }

                    Console.ResetColor();
                    Console.WriteLine("\nНажмите клавишу для повторения операции...");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                
            } while (true);
        }
    }
}

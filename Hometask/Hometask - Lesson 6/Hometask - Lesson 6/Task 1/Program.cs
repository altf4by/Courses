using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double chose;

            do
            {
                DisplayStartMenu();
                chose = GetValue("Enter the number of selected operation: ");

                switch (chose)
                {
                    case 1:
                        Addition(GetValue("Enter the first number: "), GetValue("Enter the second number: ")); break;
                    case 2:
                        Substraction(GetValue("Enter the first number: "), GetValue("Enter the second number: ")); break;
                    case 3:
                        Multiplication(GetValue("Enter the first number: "), GetValue("Enter the second number: ")); break;
                    case 4:
                        Division(GetValue("Enter the first number: "), GetValue("Enter the second number: ")); break;
                    case 5:
                        Power(GetValue("Enter the first number: "), GetValue("Enter the second number: ")); break;
                    case 6:
                        Factorial(GetValue("Enter the first number: ")); break;
                    case 7:
                        Console.Clear(); break;
                    case 8:
                        Exit(); return;
                    default:
                        if (chose.ToString().Length > 1 | chose.ToString().Length == 0)
                            DisplayError("Length of the string must be one symbol.");
                        else
                            DisplayError("Invalid operation"); 
                        Console.Clear(); break;
                }

            } while (true);            
        }
       
        static void Addition (double addent1, double addent2)
        {
            Console.WriteLine($"Result is: {addent1+addent2}");
        }

        static void Substraction(double minuend, double subtrahend)
        {
            Console.WriteLine($"Result is: {minuend - subtrahend}");
        }

        static void Multiplication(double multiplier1, double multiplier2)
        {
            Console.WriteLine($"Result is: {multiplier1 * multiplier2}");
        }

        static void Division(double dividend, double divisor)
        {
            if (divisor==0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid second value for division!!!");
                Console.ResetColor();
                return;
            }
            Console.WriteLine($"Result is: {dividend / divisor}");
        }

        static void Power(double value1, double value2)
        {
            Console.WriteLine($"Result is: {Math.Pow(value1,value2)}");
        }
        
        static void Factorial(double value)
        {
            double result = 1;
            if (value<1)
            {
                DisplayError("The Factorial is calculated  for values uqual or greater than one.");
            }
            else
            {
                for (int i = 1; i <= value; i++)
                {
                    result *= i;
                }
                Console.WriteLine($"Result is: {result}.");
            }           
        }

        static void Exit()
        {
            Console.WriteLine("Do you want exit? yes\\no");
            string answer = Console.ReadLine();
            if (answer.ToLower()=="yes")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Thank you, that used our product.");
                Console.ReadKey();
            }
        }

        static double GetValue(string inputMessage)
        {
            bool isValueValid = false;
            double value;
            do
            {
                Console.Write(inputMessage);
                isValueValid = double.TryParse(Console.ReadLine(), out value);
                if (!isValueValid)
                {
                    DisplayError("Input must be in numeric format");
                }
            } while (!isValueValid);
            return value;
        }
        
        static void DisplayStartMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"\nMain menu." +
                $"\n\nSelect operation:" +
                $"\n\n1. Addition" +
                $"\n2. Substraction" +
                $"\n3. Multiplication" +
                $"\n4. Division" +
                $"\n5. Power" +
                $"\n6. Factorial" +
                $"\n7. Clear Screen" +
                $"\n\n8. Exit\n\n");
            Console.ResetColor();
        }

        static void DisplayError(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press any key");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Gray;
            ClearLine();
        }

        static void ClearLine()
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop-2);

            }
            Console.WriteLine();            
        }
    }
}

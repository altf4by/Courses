using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] matrix1;
            int rows2;

            while (true)
            {
                StartMenu();
                matrix1 = new int
                           [GetValue("Enter the number of rows of the first matrix(a):"),
                            GetValue("Enter the number of columns of the first matrix (a):")];
                rows2 = GetValue("Enter the number of rows of the second matrix (b):");
                if (rows2 != matrix1.GetLength(1))
                {
                    DisplayError("The number of columns of the first matrix and the number of rows of the second matrix do not match.");
                    Console.Clear();
                    continue;
                }
                else
                    break;
            }


            int[,] matrix2 = new int[rows2, GetValue("Enter the number of columns of the second matrix (b):")];
            Console.WriteLine();

            FillMatrix(matrix1, rand);
            FillMatrix(matrix2, rand);

            DisplayMatrix(matrix1, "First matrix");
            DisplayMatrix(matrix2, "Second matrix");
            Console.ForegroundColor = ConsoleColor.Green;
            DisplayMatrix(MatrixMultiplication(matrix1, matrix2), "Result matrix");
            Console.ReadKey();
        }

        static void StartMenu()
        {
            Console.Title = "Calculator (version 1.0.0.1)";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Remember that the number of columns of the first matrix\n" +
                "must match the number of rows of the second matrix! \n");
            Console.ResetColor();
        }
        static int GetValue(string inputMessage)
        {
            bool isValueValid = false;
            int value;
            do
            {
                Console.Write(inputMessage);
                isValueValid = int.TryParse(Console.ReadLine(), out value);
                if (value <= 0)
                {
                    DisplayError("Input value must not be negative or equal to zero.");
                    isValueValid = false;
                }
                else
                    if (!isValueValid)
                    DisplayError("Input must be in numeric format");

            } while (!isValueValid);
            return value;
        }
        static void FillMatrix(int[,] matrix, Random rand)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    matrix[i, j] = rand.Next(1, 6);
        }
        static void DisplayMatrix(int[,] matrix, string message)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            Console.WriteLine(message);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
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
                Console.SetCursorPosition(0, Console.CursorTop - 2);
            }
            Console.WriteLine();
        }
        static int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int columns = matrix2.GetLength(1);
            int[,] matrix3 = new int[rows, columns];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    for (int k = 0; k < matrix2.GetLength(0); k++)
                        matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
            return matrix3;
        }
    }
}

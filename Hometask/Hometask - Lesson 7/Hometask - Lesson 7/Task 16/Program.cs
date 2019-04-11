using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] matrix = new int[5,5];
            int[] lineMatrix = new int[matrix.Length];
            int counter = 0;

            FillMatrix(matrix, rand);
            DisplayMatrix(matrix);

            for (int i = 0; i < matrix.GetLongLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    lineMatrix[counter] = matrix[i, j];
                    Console.Write($"{lineMatrix[counter]} ");
                    counter++;
                }

            int min = lineMatrix.Min();
            int minIndex = Array.IndexOf(lineMatrix,min);
            int max = lineMatrix.Max();
            int maxIndex = Array.IndexOf(lineMatrix, max);
            bool isMinFirst = minIndex < maxIndex;
            int sum = 0;

            for (int i = (isMinFirst?minIndex:maxIndex); ((isMinFirst) ? i<=maxIndex : i<=minIndex); i++)
            {
                sum += lineMatrix[i];
            }

            Console.WriteLine($"\n\nМинимальное значение {min}");
            Console.WriteLine($"Максимальное значение {max}");
            Console.WriteLine($"Сумма элементом между максимальным и минимальным значениями равна {sum}");
            Console.ReadKey(true);
        }

        static void FillMatrix(int[,] matrix, Random rand)
        {
            int rowsCount = matrix.GetLength(0);
            int columnsCount = matrix.GetLength(1);
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < columnsCount; j++)
                    matrix[i, j] = rand.Next(-100, 100);
        }

        static void DisplayMatrix(int[,] matrix)
        {
            int rowsCount = matrix.GetLength(0);
            int columnsCount = matrix.GetLength(1);
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

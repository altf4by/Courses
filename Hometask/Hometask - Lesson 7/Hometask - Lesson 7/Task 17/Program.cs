using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] matrix = new int[5, 5];
            int[] max = new int[matrix.GetLength(1)];

            FillMatrix(matrix, rand);
            DisplayMatrix(matrix);
            int counter = 0;

            while (counter <= 5)
            {
                int j = counter;
                for (int i = 0; i < matrix.GetLength(0); i++, j++)
                {
                    for (j = counter; j < matrix.GetLength(1); j += 5)
                    {
                        if (max[counter] <= matrix[i, j])
                            max[counter] = matrix[i, j];
                    }
                }
                counter++;
            }


            Console.Write($"Максимальные значения в столбцах: ");

            for (int i = 0; i < max.Length; i++)
                Console.Write($"{max[i]} ");

            Console.ReadKey(true);
        }
        static void FillMatrix(int[,] matrix, Random rand)
        {
            int rowsCount = matrix.GetLength(0);
            int columnsCount = matrix.GetLength(1);
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < columnsCount; j++)
                    matrix[i, j] = rand.Next(0, 100);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] matrix = new int[5, 5];
            int q = 0;
            int min = 100, max = -100;
            int[] minPosition = new int[2];
            int[] maxPosition = new int[2];
            bool isMinEarlier = false;
            int sum = 0;

            FillMatrix(matrix, rand);
            DisplayMatrix(matrix);

            //Получаем минимальное и максимальное значения и их позиции
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        minPosition[0] = i;
                        minPosition[1] = j;
                    }
                    if (matrix[i, j] >= max)
                    {
                        max = matrix[i, j];
                        maxPosition[0] = i;
                        maxPosition[1] = j;
                    }
                }
            }

            //проверяем что раньше: минимальное или максимальное
            if (minPosition[0] < maxPosition[0])
                isMinEarlier = true;
            else
                if (minPosition[0] == maxPosition[0])
                if (minPosition[1] < maxPosition[1])
                    isMinEarlier = true;

            //производим рассчет исходя из того, что раньше
            if (isMinEarlier)
                for (int i = minPosition[0]; i <= maxPosition[0]; i++)
                {
                    for (q = ((q == matrix.GetLength(1)) ? 0 : minPosition[1]); ((i != maxPosition[0]) ? q < matrix.GetLength(1) : q <= maxPosition[1]); q++)
                        sum += matrix[i, q];
                }

            else
                for (int i = maxPosition[0]; i <= minPosition[0]; i++)
                    for (q = ((q == matrix.GetLength(1)) ? 0 : maxPosition[1]); ((i != minPosition[0]) ? q < matrix.GetLength(1) : q <= minPosition[1]); q++)
                        sum += matrix[i, q];

            Console.WriteLine($"Минимальное значение \"{min}\" находится на позиции: {minPosition[0] + 1}:{minPosition[1] + 1}");
            Console.WriteLine($"Максимальное значение \"{max}\" находится на позиции: {maxPosition[0] + 1}:{maxPosition[1] + 1}");
            Console.WriteLine($"Минимальное значение находится {(isMinEarlier ? "раньше" : "позже")}.");
            Console.WriteLine($"Сумма всех элементов между минимальным и максимальным значениями равна {sum}");
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

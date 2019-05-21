﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class MathOperations
    {
        public static double MultiplyByTwo(double value)
        {
            return value * 2;
        }
        public static double Square(double value)
        {
            return value * value;
        }
    }

    class Program
    {
        static void Main()
        {
            Func<double, double>[] operations =
            {
                MathOperations.MultiplyByTwo,
                MathOperations.Square
            };

            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine("Using operations[{0}]: ", i);
                ProcessAndDisplayNumber(operations[i], 2.0);
                ProcessAndDisplayNumber(operations[i], 7.94);
                ProcessAndDisplayNumber(operations[i], 1.414);
                Console.WriteLine();
            }


            Console.ReadLine();
        }

        static void ProcessAndDisplayNumber(Func<double, double> action, double value)
        {
            double result = action(value);
            Console.WriteLine("Value is {0}, result of operation is {1}", value, result);
        }
    }

}

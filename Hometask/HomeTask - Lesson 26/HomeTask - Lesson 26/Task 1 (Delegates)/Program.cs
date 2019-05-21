using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1__Delegates_
{
    public delegate double Delegate1(Delegate2[] array);
    public delegate int Delegate2();
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов: ");
            int quantity = int.Parse(Console.ReadLine());

            Delegate2[] array = new Delegate2[quantity];

            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = () => rand.Next(0, 100);
            //array[i] = delegate () { return new Delegate2(() => rand.Next(0, 100)).Invoke(); }; -альтернативное решение

            Delegate1 d1 = delegates =>
            {
                double sum = 0;

                for (int i = 0; i < delegates.Length; i++)
                {
                    int element = delegates[i]();
                    Console.Write(element + " ");

                    sum += element;
                }
                return sum / delegates.Length;
            };

            Console.WriteLine("\nСреднее арифметическое элементов массива = {0}", d1(array));

            Console.ReadKey();
        }
    }
}

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
            Random random = new Random();
            ProtectedArray array = new ProtectedArray(5);



            array[0] = random.Next(0, 100);

            for (int i = 0; i <= array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }

            Console.ReadKey();
        }
    }

    class ProtectedArray
    {
        private readonly int[] _array;
        public int Length { get; private set; }
        public ProtectedArray(int size)
        {
            _array = new int[size];
            Length = size;
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < _array.Length)
                    return _array[index];
                else
                {
                    Console.WriteLine($"{index} - Incorrect index");
                    return int.MaxValue;
                }
            }
            set
            {
                if (index >= 0 && index < _array.Length)
                    _array[index] = value;
                else
                    Console.WriteLine($"{index} - Incorrect index");
            }
        }
    }
}

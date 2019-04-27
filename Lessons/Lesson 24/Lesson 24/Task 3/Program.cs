using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();

            list.Add(2);
            list.Add(3);
            list.Add(1);

            list.Sort();

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            int[] mas = { 3, 2, 5, 7, 2 };

            foreach (int item in mas)
            {
                Console.WriteLine(item);
            }

            //Array.Sort(mas, new Int32Comparer(Int32Comparer.CompareDirection.Descending));

            Array.Sort(mas, (x, y) => x.CompareTo(y));

            Console.WriteLine();

            foreach (int item in mas)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
    
    class Int32Comparer : IComparer<int>
    {
        public enum CompareDirection
        {
            Ascending,
            Descending
        }

        private CompareDirection _compareDirection;

        public Int32Comparer(CompareDirection compareDirection)
        {
            _compareDirection = compareDirection;
        }

        public int Compare(int x, int y)
        {
            switch (_compareDirection)
            {
                case CompareDirection.Ascending: return x.CompareTo(y);
                case CompareDirection.Descending: return -x.CompareTo(y);
                default:  throw new Exception("Error");
            }
        }
    }
}

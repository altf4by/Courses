using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4__ArrayList_
{
    class Program
    {
        static void Main()
        {
            var list = new ArrayList { 2, 3, 1 };

            list.Sort(new DescendingComparer());

            foreach (int item in list)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }

    public class DescendingComparer : IComparer
    {
        // Проверяет равенство двух объектов без учета регистра строк.
        readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

        public int Compare(object x, object y)
        {
            // Для сортировки по убыванию.
            // Объекты, переданные для сравнения, меняются местами.
            int result = -1 * comparer.Compare(x, y);

            //int result = comparer.Compare(y, x);
            return result;
        }
    }

    //public class DescendingComparer : IComparer
    //{
    //    public int Compare(object x, object y)
    //    {
    //        int x1 = (int)x;
    //        int y1 = (int)y;

    //        if (x1 < y1)
    //            return 1;
    //        else if (x1 > y1)
    //            return -1;
    //        else
    //            return 0;
    //    }
    //}

}

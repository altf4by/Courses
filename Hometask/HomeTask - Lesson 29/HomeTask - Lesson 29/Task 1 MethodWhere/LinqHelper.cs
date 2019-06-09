using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_MethodWhere
{
    static class LinqHelper
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T,bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                    yield return item;
            }
        }
    }
}

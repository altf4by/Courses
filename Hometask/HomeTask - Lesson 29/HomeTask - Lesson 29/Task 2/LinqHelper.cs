using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    static class LinqHelper
    {
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector)
        {
            foreach (var item1 in outer)
                foreach (var item2 in inner)
                {
                    yield return resultSelector(item1, item2);
                }


            
        }
    }
}

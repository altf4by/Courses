using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class AutoPriceComparer: IComparer
    {
        public int Compare(object auto1, object auto2)
        {
            return ((Auto)auto1).Cost.CompareTo(((Auto)auto2).Cost);
        }
    }
}

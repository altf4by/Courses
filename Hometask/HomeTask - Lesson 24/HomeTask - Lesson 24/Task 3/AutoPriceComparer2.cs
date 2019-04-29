using System;
using System.Collections.Generic;

namespace Task_3
{
    class AutoPriceComparer2 : IComparer<Auto>
    {

        public int Compare(Auto auto1, Auto auto2)
        {
            return auto1.Cost.CompareTo(auto2.Cost);
        }
    }
}

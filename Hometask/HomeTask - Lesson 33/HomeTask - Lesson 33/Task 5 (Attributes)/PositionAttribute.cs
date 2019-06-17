using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5__Attributes_
{
    [AttributeUsage(AttributeTargets.All)]
    class PositionAttribute : Attribute
    {
        private int number;
        public int Number { get => number; }
        public PositionAttribute(int numb)
        {
            number = numb;
        }
    }
}

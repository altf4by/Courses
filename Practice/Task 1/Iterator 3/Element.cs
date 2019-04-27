using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_3
{
    class Element
    {
        public int Field1 { get; set; }
        public int Field2 { get; set; }

        public Element(int field1, int field2)
        {
            Field1 = field1;
            Field2 = field2;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Field1, Field2);
        }
    }
}

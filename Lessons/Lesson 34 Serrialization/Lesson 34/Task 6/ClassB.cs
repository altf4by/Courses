using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{[Serializable]
    class ClassB
    {
        int number;
        int c;

        public ClassB()
        {

        }
        public void Method(int n, int c)
        {
            number = n;
            this.c = c;
        }
    }
}

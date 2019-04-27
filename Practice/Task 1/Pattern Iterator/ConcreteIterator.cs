using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Iterator
{
    class ConcreteIterator : Iterator
    {
        private readonly ConcreteAgregate agregate;
        private int current;

        public ConcreteIterator(ConcreteAgregate agregate)
        {
            this.agregate = agregate;
        }

        public override object Current()
        {
            return agregate[current];
        }

        public override object First()
        {
            return agregate[0];
        }

        public override bool IsDone()
        {
            return current >= agregate.Count-1;
        }

        public override object Next()
        {
            object element = null;

            if (current<agregate.Count-1)
                element = agregate[++current];

            return element;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Iterator
{
    class ConcreteAgregate : Agregate
    {
        private readonly ArrayList elements = new ArrayList();

        private ConcreteIterator iterator;


        public override object this[int index]
        {
            get { return elements[index]; }
            set { elements.Insert(index,value); }
        }

        public override Iterator CreateIterator()
        {
            iterator = new ConcreteIterator(this);
            return iterator;
        }

        public int Count { get { return elements.Count; } }

    }
}

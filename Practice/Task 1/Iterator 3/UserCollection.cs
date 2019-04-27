using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_3
{
    class UserCollection : IEnumerable, IEnumerator
    {
        private Element[] elements = new Element[4];

        int position = -1;

        public Element this[int index]
        {
            get { return elements[index]; }
            set
            {
                if (index <= elements.Length)
                    elements[index] = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public object Current { get { return elements[position]; } }

        public bool MoveNext()
        {
            if (position < elements.Length - 1)
            {
                position++;
                return true;
            }
            else { Reset(); return false; }

        }

        public void Reset()
        {
            position = -1;
        }
    }
}

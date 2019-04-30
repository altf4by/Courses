using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class LinkedList<T> : IEnumerable
    {
        public Element<T> First { get; private set; }
        public Element<T> Last { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        public LinkedList(T data)
        {
            Element<T> element = new Element<T>(data);
            SetFirstAndLast(element);
        }

        public Element<T> AddLast(T data)
        {
            Element<T> element = new Element<T>(data);

            if (Last != null)
            {
                Last.Prev = Count == 1 ? null : Last;
                Last.Next = element;
                First = Count == 1 ? Last : First;
                element.Prev = Last;
                Last = element;
                Count++;
            }
            else
                SetFirstAndLast(element);

            return element;
        }

        private void SetFirstAndLast(Element<T> element)
        {
            First = element;
            Last = element;
            Count = 1;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetCollection(T data)
        {
            yield return AddLast(data);
        }
    }
}

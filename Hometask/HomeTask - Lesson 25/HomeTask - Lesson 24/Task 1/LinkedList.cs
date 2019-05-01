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

        public void AddLast(T data)
        {
            Element<T> newElement = new Element<T>(data);

            if (Last != null)
            {
                Last.Prev = Count == 1 ? null : Last;
                Last.Next = newElement;
                First = Count == 1 ? Last : First;
                newElement.Prev = Last;
                Last = newElement;
                Count++;
            }
            else
                SetFirstAndLast(newElement);
        }

        public void AddAfterByValue(T elementData, T data)
        {
            Element<T> newElement = new Element<T>(data);
            Element<T> current = First;

            if (elementData != null)
            {
                //Вставка после по значению элемента
                while (!elementData.Equals(current.Data))
                    current = current.Next;

                newElement.Next = current.Next;
                newElement.Prev = current;
                current.Next = newElement;
                Count++;
            }

        }
        public void AddAfterByPosition(int position, T data)
        {
            Element<T> newElement = new Element<T>(data);
            Element<T> current = First;
            int tempCount = 1;

            if (position >= 1 && position < Count)
            {
                //Вставка после по индексу элемента
                while (position != tempCount)
                {
                    tempCount++;
                    current = current.Next;
                }

                newElement.Next = current.Next;
                newElement.Prev = current;
                current.Next = newElement;
                Count++;
            }

        }

        private void SetFirstAndLast(Element<T> element)
        {
            First = element;
            Last = element;
            Count = 1;
        }

        public IEnumerator GetEnumerator()
        {
            Element<T> current = First;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

    }
}

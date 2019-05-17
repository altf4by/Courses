using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_1
{
    class LinkedList<T> : IEnumerable
    {
        public Element<T> First { get; private set; }
        public Element<T> Last { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
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
                Last.Next = newElement;
                newElement.Prev = Last;
                Last = newElement;

                Count++;
            }
            else
                SetFirstAndLast(newElement);
        }

        public void AddAfterByValue(T target, T data)
        {
            Element<T> newElement = new Element<T>(data);
            Element<T> current = First;

            if (target != null)
            {
                while (!target.Equals(current.Data))
                    current = current.Next;

                newElement.Next = current.Next;
                current.Next.Prev = newElement;
                newElement.Prev = current;
                current.Next.Prev = newElement;
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
                while (position != tempCount)
                {
                    tempCount++;
                    current = current.Next;
                }

                newElement.Next = current.Next;
                current.Next.Prev = newElement;
                newElement.Prev = current;
                current.Next.Prev = newElement;
                current.Next = newElement;

                Count++;
            }
        }

        public void Delete(T data)
        {            
            Element<T> current = First;

            while (current != null)
            {
                if (current.Data.Equals(data))
                    break;
                else
                    current = current.Next;
            }
                
            if (Count == 1)
            {
                First = null;
                Last = null;
                Count--;
                throw new ArgumentNullException("Linked list is empty.");
            }

            if (current != First && current != Last)
            {
                current.Prev.Next = current.Next;
                current.Next.Prev = current.Prev;

                Count--;
            }
            else
            {
                if (current == First && current != Last)
                {
                    current.Next.Prev = null;
                    First = current.Next;
                }
                else
                {
                    current.Prev.Next = null;
                    Last = current.Prev;
                }
            }

            //else { throw new NullReferenceException("First element is null"); }
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

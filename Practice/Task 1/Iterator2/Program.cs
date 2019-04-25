using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator2
{
    class Program
    {
        static void Main(string[] args)
        {
            UserCollection uc = new UserCollection();

            foreach (var item in uc)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }
    }

    class Element
    {
        public string Name { get; set; }
        public Element(string name)
        {
            Name = name;
        }
    }

    class UserCollection : IEnumerable, IEnumerator
    {
        Element[] elements;

        int position = -1;

        public UserCollection()
        {
            elements = new Element[3];
            elements[0] = new Element("One");
            elements[1] = new Element("Two");
            elements[2] = new Element("Three");
        }

        public object Current { get { return elements[position]; } }

        public IEnumerator GetEnumerator()
        {
            return this as IEnumerator ;
        }

        public bool MoveNext()
        {
            if (position < elements.Length-1 )
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

using System;
using System.Collections;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            UserCollection myCollection = new UserCollection();

            // Используем foreach, для обращения к каждому объекту Element внутри массива myCollection. 
            foreach (Element element in myCollection)
            {
                Console.WriteLine("Name: {0}  Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }

            //myCollection.Reset(); // Убрать комментарий для проверки.

            Console.Write(new string('-', 29) + "\n");

            // Используем foreach, для повторного обращения к каждому объекту Element внутри массива myCollection.
            foreach (Element element in myCollection)
            {
                Console.WriteLine("Name: {0}  Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }

            Console.Write(new string('-', 29) + "\n");


            // --------------------------------------------------------------------------
            // Так работает foreach.

            UserCollection myElementsCollection = new UserCollection();

            // foreach - приводит коллекцию к интерфейсному типу IEnumerable.
            IEnumerable enumerable = myElementsCollection as IEnumerable;

            // foreach - приводит коллекцию к интерфейсному типу вызывая метод - GetEnumerator().            
            IEnumerator enumerator = enumerable.GetEnumerator();


            while (enumerator.MoveNext())
            {
                Element element = enumerator.Current as Element;

                Console.WriteLine("Name: {0}  Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }


            enumerator.Reset();

            Console.ReadKey();
        }

    }

    public class Element
    {
        private string name;
        private int field1;
        private int field2;

        public Element(string s, int a, int b)
        {
            name = s;
            field1 = a;
            field2 = b;
        }

        public int Field1
        {
            get { return field1; }
            set { field1 = value; }
        }

        public int Field2
        {
            get { return field2; }
            set { field2 = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    public class UserCollection : IEnumerable, IEnumerator
    {
        public Element[] elementsArray = null;

        public UserCollection()
        {
            elementsArray = new Element[4];
            elementsArray[0] = new Element("A", 1, 10);
            elementsArray[1] = new Element("B", 2, 20);
            elementsArray[2] = new Element("C", 3, 30);
            elementsArray[3] = new Element("D", 4, 40);
        }

        int position = -1;

        public bool MoveNext()
        {
            if (position < elementsArray.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get { return elementsArray[position]; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
    }

}

using System;
using System.Collections.Generic;
namespace Task_4
{
    public class Person : IComparable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int CompareTo(object obj)
        {
            Person person = obj as Person;
            if (person != null)
                return LastName.CompareTo(person.LastName);

            else throw new Exception("Невозможно сравнить два объекта");
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }


    }

}

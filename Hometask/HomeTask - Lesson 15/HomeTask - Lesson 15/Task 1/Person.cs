using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Person
    {
        private string _firstName;
        private string _secondName;
        public string FullName { get { return _firstName + " " + _secondName; }}

        public Person(string firstName, string secondName)
        {
            _firstName = firstName;
            _secondName = secondName;
        }

        public virtual void SayHello()
        {
            Console.WriteLine("Hello from Person");
        }
    }
}

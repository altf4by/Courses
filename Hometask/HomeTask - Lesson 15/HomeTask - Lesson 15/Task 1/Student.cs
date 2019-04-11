using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    sealed class Student : Person
    {
        public Student(string firstName, string secondName) : base(firstName, secondName)
        {
        }

        public override void SayHello()
        {
            Console.WriteLine("Hello from student {0}",FullName);
        }
    }
}

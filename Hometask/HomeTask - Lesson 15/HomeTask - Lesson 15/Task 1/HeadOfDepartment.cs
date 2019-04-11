using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class HeadOfDepartment : Teacher
    {
        public HeadOfDepartment(string firstName, string secondName) : base(firstName, secondName,"professor")
        {
        }
        public override void SayHello()
        {
            Console.WriteLine("Hello from head of department {0}", FullName);
        }
    }
}

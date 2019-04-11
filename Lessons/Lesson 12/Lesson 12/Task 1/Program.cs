using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Peter";

            Console.WriteLine(student.Name);
        }



    }

    class Student
    {
        string _name;
        string _surname;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _name = value;
                else Console.WriteLine("Message must not be empty"); 
            }

        }

    }
}

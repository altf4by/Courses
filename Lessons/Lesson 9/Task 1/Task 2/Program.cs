using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Student student2 = new Student("Dima", "Sidorov", 23);

            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetSurname());
            Console.WriteLine(student.GetAge());

            Console.WriteLine();
            Console.WriteLine(student2.GetName());
            Console.WriteLine(student2.GetSurname());
            Console.WriteLine(student2.GetAge());


            Console.ReadKey(true);
        }
    }
    class Student
    {
        private string _name;
        private string _surName;
        private byte _age;

        public Student()
        {
            _name = "Ivan";
            _surName = "Ivanov";
            _age = 24;
        }
        public Student (string name, string surName, byte age)
        {
            _name = name;
            _surName = surName;
            _age = age;
        }

        public void SetName (string name)
        {
            _name = name;
        }
        public void SetSurname(string surName)
        {
            _surName = surName;
        }
        public void SetAge(byte age)
        {
            _age = age;
        }

        public string GetName()
        {
            return _name;
        }
        public string GetSurname()
        {
            return _surName;
        }
        public byte GetAge()
        {
            return _age;
        }

    }

}

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
            Student.SetUniversity("bseu");
            Student student = new Student("Ivan","Ivanov",23);
            Student student2 = new Student("Petr", "Ivanov", 23);

            Student[] array = new Student[2];
            array[0] = student;
            array[1] = student2;

            array[2].SetName("vlad");


            Console.ReadKey();
        }
    }
    class Student
    {
        private string _name;
        private string _surName;
        private byte _age;
        public static string universityName;


        public Student(string name, string surName, byte age)
        {
            _name = name;
            _surName = surName;
            _age = age;
            Console.WriteLine("instance");
        }
        static Student()
        {
            universityName = string.Empty;
            Console.WriteLine("static");
        }


        

        public void SetName(string name)
        {
            _name = name;
        }
 

        public string GetName()
        {
            return _name;
        }
            
        public static void SetUniversity(string name)
        {
            universityName = name;
        }

    }
}

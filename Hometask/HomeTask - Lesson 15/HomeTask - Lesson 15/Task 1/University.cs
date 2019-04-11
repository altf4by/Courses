using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class University
    {

        private Person[] people;
        private int Count { get; set; }
        public int Length { get { return people.Length; } }

        public University()
        {
            people = new Person[0];
        }
        public University(Person person)
        {
            if (Count <= Length && person != null)
            {
                Array.Resize(ref people, Length + 1);
                people[Count++] = person;
            }
            else Console.WriteLine("Некорректный ввод");
        }

        public Person this[int index]

        {
            get
            {
                if (index >= 0 && index <= Length)
                    return people[index];
                else return null;
            }
            set
            {
                if (index >= 0 && index <= Length && value != null)
                    people[index] = value;
                else
                    Console.WriteLine("Некорректный ввод");
            }
        }

        public void AddStudent(Student student)
        {
            AddPerson(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            AddPerson(teacher);
        }

        public void AddHeadOfDepartment(HeadOfDepartment headOfDepartment)
        {
            AddPerson(headOfDepartment);
        }

        public void AddPerson(Person person)
        {
            if (Count <= Length && person != null)
            {
                Array.Resize(ref people, Length + 1);
                people[Count++] = person;
            }
        }
    }
}

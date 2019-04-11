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
            University bseu = new University();

            bseu.AddStudent(new Student("Ivan", "Ivanov"));
            bseu.AddStudent(new Student("Petr", "Petrov"));
            bseu.AddStudent(new Student("Semen", "Semenov"));
            bseu.AddStudent(new Student("Pavel", "Pavlov"));

            bseu.AddTeacher(new Teacher("Mark", "Markov","docent"));
            bseu.AddTeacher(new Teacher("Gavr", "Gavrilov", "aspirate"));

            bseu.AddHeadOfDepartment(new HeadOfDepartment("Boss", "Bossovich"));




            for (int i = 0; i < bseu.Length; i++)
            {
                bseu[i].SayHello();
            }

            Console.ReadKey();
        }
    }
}

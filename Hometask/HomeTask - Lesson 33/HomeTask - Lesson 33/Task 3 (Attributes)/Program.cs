using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3__Attributes_.Workers;

namespace Task_3__Attributes_
{
    class Program
    {
        static void Main(string[] args)
        {
            Section section = new Section();

            Director director = new Director("Peter Hals");
            Programmer programmer = new Programmer("Mark Stevens");
            Manager manager = new Manager("Michael Lowrence");

            section.AllowAcces(director);
            section.AllowAcces(programmer);
            section.AllowAcces(manager);


            Console.ReadKey();
        }
    }
}

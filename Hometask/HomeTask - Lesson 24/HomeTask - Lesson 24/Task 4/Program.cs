using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var collect = new List<Person>
                    {
                     new Person{FirstName = "Damon", LastName = "Hill"},
                     new Person{FirstName = "Niki", LastName = "Lauda"},
                     new Person{FirstName = "Ayrton", LastName = "Senna"},
                     new Person{FirstName = "Graham", LastName = "Hill"},
                     new Person{FirstName = "Damon", LastName = "Crauch"}
                    };
            Console.WriteLine("Before sort: \n");

            foreach (Person person in collect)
                Console.WriteLine(person.ToString());

            collect.Sort();

            Console.WriteLine("\nAfter sort: \n");

            foreach (Person person in collect)
                Console.WriteLine(person.ToString());

            Console.ReadKey();

        }
    }
}

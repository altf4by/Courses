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
            var list = new List<Student>
            {
                new Student(17,"Student1"),
                new Student(25,"Student2"),
                new Student(21,"Student3"),
            };

            var averAge = list.Average(st => st.Age);
            var maxAge = list.Max(st => st.Age);

            Console.WriteLine(averAge);
            Console.WriteLine(maxAge);

            var query = from st in list
                        group st by st.Age < 18 into gr
                        select new
                        {
                            GroupName = gr.Key ? "younger" : "elder",
                            Count = gr.Count(),
                            Group = gr.OrderByDescending(st=>st.Age)
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"{item.GroupName} : {item.Count.ToString()}");

                foreach (var st in item.Group)
                {
                    Console.WriteLine($"{st.Name} - {st.Age}");
                }

                Console.WriteLine(new string('-',20));
            }

            Console.ReadKey();
        }
    }

    class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Student(int age, string name)
        {
            Age = age;
            Name = name;
        }
    }
}

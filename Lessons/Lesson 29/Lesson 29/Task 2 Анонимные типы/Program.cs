using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Анонимные_типы
{
    class Program
    {
        static void Main()
        {
            var instance = new { Name = "Alex", Age = 27 };
            var instance2 = new { Name = "Alex", Age = 27, Lname = "+sadasd" };
            Console.WriteLine("Name = {0}, Age = {1}", instance.Name, instance.Age);

            Type type = instance.GetType();

            Console.WriteLine(type.ToString());


            var mas = new[] { instance, new { Name = "Alex", Age = 28 } };

            foreach (var item in mas)
            {
                Console.WriteLine(item.Age);
            }

            Console.ReadKey();
        }
    }

}

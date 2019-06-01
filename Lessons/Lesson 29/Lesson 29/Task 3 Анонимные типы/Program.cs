using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Анонимные_типы
{
    class Program
    {
        static void Main()
        {

            var instance = new { Name = "Alex", Age = 27, Id = new { Number = 123 } };

            Console.WriteLine("Name = {0}, Age = {1}, Id = {2}", instance.Name, instance.Age, instance.Id.Number);

            Console.ReadKey();
        }
    }

}

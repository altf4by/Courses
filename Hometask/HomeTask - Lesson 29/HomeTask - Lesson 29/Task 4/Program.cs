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
            var query1 = from c in CIniCustomer.IniCustomer()
                         where c.Region == "Азия"
                         select c;

            var query11 = CIniCustomer.IniCustomer()
                          .Where(customer => customer.Region == "Азия")
                          .Select(customer => customer);

            Console.WriteLine("1. Сформировать LINQ-запрос на получение коллекции заказчиков (Customer) из региона “Азия”:");
            foreach (var customer in query11)
                Console.WriteLine(customer.ToString());

            var query2 = from c in CIniCustomer.IniCustomer()
                         where c.Region == "Азия"
                         select c.City;

            var query22 = CIniCustomer.IniCustomer()
                          .Where(c => c.Region.Equals("Азия"))
                          .Select(c => c.City);

            Console.WriteLine("\n2. Сформировать LINQ-запрос на получение коллекции городов, в которых проживают заказчики (Customer) из региона “Азия”:");
            foreach (var city in query22)
                Console.WriteLine(city);

            var query3 = from c in CIniCustomer.IniCustomer()
                         group c by c.Region into item
                         let total = item.Sum(c => c.Sales)
                         orderby total descending
                         select new { Region = item.Key, Total = total };

            Console.WriteLine("\n3. Сформировать LINQ-запрос на получение общей суммы продаж конкретно по каждому региону и отсортировать по убыванию.");
            foreach (var gr in query3)
                Console.WriteLine($"{} - {(from g in gr orderby g.Sales descending select g.Sales).Sum()}");


            Console.ReadKey();
        }
    }
}

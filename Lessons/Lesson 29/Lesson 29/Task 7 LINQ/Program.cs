using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_LINQ
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // База данных сотрудников.
            var employees = new List<Employee>
            {
                new Employee
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Salary = 94000,
                    StartDate = DateTime.Parse("1/4/1992")
                },
                new Employee
                {
                    FirstName = "Petr",
                    LastName = "Petrov",
                    Salary = 123000,
                    StartDate = DateTime.Parse("12/3/1985")
                },
                new Employee
                {
                    FirstName = "Andrew",
                    LastName = "Andreev",
                    Salary = 1000000,
                    StartDate = DateTime.Parse("1/12/2005")
                }
            };

            // Выражение запроса.
            var query = // query - переменная запрса.
                        from employee in employees // from - объявляет переменную диапазона employee.
                        where employee.Salary > 100000 // where - фильтр
                        orderby employee.LastName, employee.FirstName
                        select new // select - Опреация проекции.
                        {
                            LastName = employee.LastName,
                            FirstName = employee.FirstName
                        };
            var query2 =
                        employees
                        .Where(emp => emp.Salary > 100000)
                        .OrderBy(emp => emp.LastName)
                        .ThenBy(emp => emp.FirstName)
                        .Select(emp => new
                        {
                            LastName = emp.LastName,
                            FirstName = emp.FirstName
                        });
            var query3 =
                Enumerable.Select(
                Enumerable.OrderBy(
                Enumerable.OrderBy(
                Enumerable.Where(
                employees, emp => emp.Salary > 100000),
                emp => emp.LastName),
                emp => emp.FirstName),
                emp => new { LastName = emp.LastName, FirstName = emp.FirstName });

            Console.WriteLine("Высокооплачиваемые сотрудники:");




            Console.WriteLine("Высокооплачиваемые сотрудники:");

            foreach (var item in query)
                Console.WriteLine("{0} {1}", item.LastName, item.FirstName);

            Console.ReadKey();
        }
    }

}

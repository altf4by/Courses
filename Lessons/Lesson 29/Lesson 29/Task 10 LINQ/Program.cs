using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_LINQ
{
    public class EmployeeID
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class EmployeeNationality
    {
        public string Id { get; set; }
        public string Nationality { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var employees = new List<EmployeeID>
            {
                new EmployeeID {Id = "111", Name = "Ivan Ivanov"},
                new EmployeeID {Id = "222", Name = "Andrey Andreev"},
                new EmployeeID {Id = "333", Name = "Petr Petrov"},
                new EmployeeID {Id = "444", Name = "Alex Alexeev"}
            };

            var empNationalities = new List<EmployeeNationality>
            {
                new EmployeeNationality {Id = "111", Nationality = "Russian"},
                new EmployeeNationality {Id = "222", Nationality = "Ukrainian"},
                new EmployeeNationality {Id = "333", Nationality = "American"},
            };

            var query = from emp in employees
                        join n in empNationalities
                        on emp.Id equals n.Id into result
                        from t in result.DefaultIfEmpty()

                        orderby emp.Name descending
                        select new
                        {
                            Id = emp.Id,
                            Name = emp.Name,
                            Nationality = t == null ? "NoData" : t.Nationality
                        };

            foreach (var person in query)
                Console.WriteLine("{0}, {1}, \t{2}", person.Id, person.Name, person.Nationality);

            Console.ReadKey();
        }
    }

}

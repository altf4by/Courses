using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
              new Car("Volvo", "S80", 2005, "Black"),
              new Car("Mercedes", "S600", 2015, "White"),
              new Car("Opel", "Vectra", 2012, "Green"),
              new Car("Fiat", "Stilo", 2001, "Grey"),
              new Car("Lada", "Vesta", 2017, "Bronze")
            };

            List<Customer> customers = new List<Customer>()
            {
                new Customer("Phil", 1234567, "S80"),
                new Customer("Roth", 2345661, "S600"),
                new Customer("Jack", 1454342, "Vectra"),
                new Customer("Andrew", 12342321, "Vesta"),
                new Customer("Rob", 244112422, "Stilo"),
            };


            var query = from car in cars
                        join customer in customers
                        on car.Model equals customer.Model
                        orderby customer.Name
                        select new { customer.Name, customer.PhoneNumber, car.Brand, car.Model, car.Year, car.Color };

            //var query2 = cars
            //    .Join (customers, car => car.Model, customer => customer.Model, (car, customer) => car.Model.Equals(customer.Model))
            //    .Select(

            foreach (var item in query)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }



    }
}

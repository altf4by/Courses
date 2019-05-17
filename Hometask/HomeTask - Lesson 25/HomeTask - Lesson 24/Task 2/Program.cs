using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Category molochka = new Category("Молочка");

            Product moloko = new Product("Молоко", molochka, 1);
            Product kefir = new Product("Кефир", molochka, 1);
            Product hleb = new Product("Хлеб");


            Customer alex = new Customer("Alex");
            alex.AddProduct(moloko);

            Customer peter = new Customer("Peter", moloko, hleb, kefir);

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store("store1");

            store.AddArticle(new Article("product1","store1", 15.5));
            store.AddArticle(new Article("product2", "store1", 22));
            store.AddArticle(new Article("product3", "store1", 17));

            store.AddNewArticle();
            store[1].DisplayInfo();
            store[0].DisplayInfo();
            store["product3"].DisplayInfo();

            Console.Write("Please, enter the name of the product you want information to display: ");
            string product_name = Console.ReadLine();
            store[product_name].DisplayInfo();


            Console.ReadKey(true);
        }
    }
}

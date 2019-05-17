using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Customer
    {
        public string Name { get; set; }
        public int ID { get; set; }
        private static int Id;

        public List<Product> productsInCart;

        public Customer(string name)
        {
            Name = name;
            productsInCart = new List<Product>();
            ID = Id++;
        }

        public Customer(string name, params Product[] products) :this (name)
        {
            productsInCart = new List<Product>();

            foreach (Product product in products)
                productsInCart.Add(product);
        }

        public void AddProduct(Product product)
        {
            if (!productsInCart.Contains(product))
                productsInCart.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            //if (productsInCart.Contains(product))
            //    productsInCart.Remove(product);

            int count = 0;
            foreach (Product prod in productsInCart)
            {
                if (prod == product)
                    productsInCart.RemoveAt(count);

                count++;
            }
        }

    }
}

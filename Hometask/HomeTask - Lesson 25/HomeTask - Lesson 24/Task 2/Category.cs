using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_2
{
    class Category
    {
        public string Name { get; set; }

        private Hashtable products2;

        public Category(string name)
        {
            Name = name;
            products2 = new Hashtable();
        }

        public void AddProduct(Product product)
        {
            products2.Add(product.Name, Name);
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(Name.ToString().Substring(0, 1));
        }

        public override string ToString()
        {
            return Name;
        }

        public IEnumerable GetProductsByCategory(Category category)
        {
            foreach (Product product in products2)
                if (category.Name==Name)
                    yield return product;
        }
    }
}

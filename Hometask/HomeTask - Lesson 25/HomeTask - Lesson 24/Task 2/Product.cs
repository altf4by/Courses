using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Product
    {
        public string Name { get; }
        public Category Category { get; set; }

        public Product(string name, Category category)
        {
            Name = name;
            Category = category;
            category.AddProduct(this);

        }
        public Product(string name) : this(name, new Category("Продукт"))
        {
        }
    }
}

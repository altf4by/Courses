using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Article
    {
        private string _productName;
        private string _storeName;
        private double _price;

        public Article(string productName, string storeName, double price)
        {
            _productName = productName;
            _storeName = storeName;
            if (price>=0)
                _price = price;
            else
            {
                Console.WriteLine("Price can not be less than 0");
                _price = 0;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Product name: {0}\t Store name: {1}\t Price: {2} $", _productName, _storeName, _price);
        }
        public string GetProductName()
        {
            return _productName;
        }
    }
}

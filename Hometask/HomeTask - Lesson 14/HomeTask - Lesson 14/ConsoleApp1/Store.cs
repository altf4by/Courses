using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Store
    {
        private Article[] _articles;
        private int Length { get; set; }
        private string Name { get; set; }

        public Store()
        {
            _articles = new Article[0];
            Length = _articles.Length;
        }

        public Store(string name) : this()
        {
            Name = name;
        }

        public Article this[int index]
        {

            get
            {
                if (index >= 0 && index <= Length)
                    return _articles[index];
                else
                {
                    Console.WriteLine("Incorrect index of the article");
                    return null;
                }
            }
        }

        public Article this[string index]
        {
            get
            {
                if (!string.IsNullOrEmpty(index))
                {
                    foreach (Article article in _articles)
                    {
                        if (article.GetProductName() == index)
                            return article;
                    }

                    Console.WriteLine("There is no product with such name!");
                    return null;
                }
                else
                {
                    Console.WriteLine("Incorrect index of the article");
                    return null;
                }
            }
        }

        public void AddArticle(Article article)
        {
            Array.Resize(ref _articles, ++Length);
            _articles[Length - 1] = article;
        }

        public void AddNewArticle()
        {
            Array.Resize(ref _articles, ++Length);
            Console.Write("Please, enter name of Article: ");
            string name = Console.ReadLine();
            Console.Write("Please, enter price of the article: ");
            double price = Double.Parse(Console.ReadLine());
            _articles[Length - 1] = new Article(name, this.Name, price);
        }
    }
}

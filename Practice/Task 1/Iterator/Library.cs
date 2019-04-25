using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Library : IEnumerable
    {
        Book[] books = null;
        public int position { get; set; }

        IEnumerator enumerator = new LibraryEnumerator();

        public Library()
        {
            books = new Book[4];
            books[0] = new Book("Война и Мир");
            books[1] = new Book("Онегин");
            books[2] = new Book("Капитанская дочка");
            books[3] = new Book("Вий");
        }

        public IEnumerator GetEnumerator()
        {
            return enumerator;
        }
    }
}

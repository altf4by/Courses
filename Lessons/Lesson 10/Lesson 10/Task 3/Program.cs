using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Book
    {
        private Title title;
        private Content content;
        private Author author;

        public Book(string title, string content, string author)
        {
            this.title = new Title(title);
            this.content = new Content(content);
            this.author = new Author(author);
        }

        public void Show()
        {
            title.Show();
            content.Show();
            author.Show();
        }


    }

    class Author
    {
        string name;
        public Author(string name)
        {
            this.name = name;
        }
        public void Show()
        {
            Console.WriteLine(name);
        }
    }

    class Title
    {
        string name;
        public Title(string name)
        {
            this.name = name;
        }
        public void Show()
        {
            Console.WriteLine(name);
        }
    }

    class Content
    {
        string name;
        public Content(string name)
        {
            this.name = name;
        }
        public void Show()
        {
            Console.WriteLine(name);
        }
    }
}

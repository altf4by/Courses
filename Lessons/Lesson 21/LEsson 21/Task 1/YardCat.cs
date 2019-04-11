using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class YardCat : IHomeCat
    {
        public string Name { get; set; }

        public void Meow()
        {
            Console.WriteLine("Мяу мяу!");
        }

        public void Scratch()
        {
            Console.WriteLine("Я царапаюсь, но не сильно");
        }
    }

}

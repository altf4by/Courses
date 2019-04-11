using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class PedigreeCat : IHomeCat
    {
        public string Name { get; set; }

        public void Meow()
        {
            Console.WriteLine("Урррррр уррррр");
        }

        public void Scratch()
        {
            Console.WriteLine("Я не царапаюсь");
        }
    }

}

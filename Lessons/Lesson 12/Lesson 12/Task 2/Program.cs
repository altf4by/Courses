using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            m.X = 90;

            Console.WriteLine(m.NNN);
            Console.ReadKey();
        }
    }
    class MyClass
    {

        private int x;

        public int X
        {
            get { return x; }
            set { X = value; }
        }

        public string Name { get; private set; }
        public MyClass()
        {
            Name = "";
        }
        public string NNN
        {
            get { return string.Format("agfg {0}", 345); }
        }
    }
}

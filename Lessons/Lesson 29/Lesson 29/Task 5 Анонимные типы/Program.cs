using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Анонимные_типы
{
    delegate void MyDelegate(string str);

    class Program
    {
        static void Main()
        {
            var instance = new
            {
                MyDel = new MyDelegate((string str) => Console.WriteLine(str))
            };

            instance.MyDel("Hello world!");

            Console.ReadKey();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    struct MyStruct
    {
        public int MyProperty { get; set; }
    }

    class Program
    {
        static void Main()
        {
            MyStruct instance = new MyStruct();

            //instance.MyProperty = 1;
            Console.WriteLine(instance.MyProperty);

            Console.ReadKey();
        }
    }

}

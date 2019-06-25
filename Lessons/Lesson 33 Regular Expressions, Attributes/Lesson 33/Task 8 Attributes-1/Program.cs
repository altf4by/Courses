using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Attributes_1
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    class MyAttribute : System.Attribute
    {
        private readonly string date;
        public string Date
        {
            get { return date; }
        }

        // Позиционные параметры задаются формальными параметрами - public конструктора, класса атрибута.
        public MyAttribute(string date)
        {
            this.date = date;
        }

        // Именованные параметры задаются открытыми нестатическими полями или свойствами, класса атрибута.
        public int Number { get; set; }
    }



    [My("1/31/2008", Number = 1)]
    public class MyClass
    {
        [MyAttribute("2/31/2007", Number = 2)]
        public static void Method()
        {
            Console.WriteLine("MyClass.Method()\n");
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();
            MyClass.Method();


            Console.ReadKey();
        }
    }

}

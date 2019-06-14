using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_Attributes_2
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    class MyAttribute : System.Attribute
    {
        private readonly string date;
        public string Date
        {
            get { return date; }
        }

        public MyAttribute(string date)
        {
            this.date = date;
        }

        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
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


            Type type = typeof(MyClass);
            object[] attributes = null;

            MyAttribute attribute = null;

            attributes = type.GetCustomAttributes(false);

            foreach (object attributeType in attributes)
            {
                attribute = attributeType as MyAttribute;
                Console.WriteLine("Анализ типа  : Number = {0}, Date = {1}", attribute.Number, attribute.Date);
            }


            MethodInfo method = type.GetMethod("Method", BindingFlags.Public | BindingFlags.Static);

            attributes = method.GetCustomAttributes(typeof(MyAttribute), false);

            foreach (MyAttribute attrib in attributes)
            {
                Console.WriteLine("Анализ метода: Number = {0}, Date = {1}", attrib.Number, attrib.Date);
            }

            Console.ReadKey();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_Attributes_3
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
    public class MyAttribute : System.Attribute
    {
        private readonly string text;
        private readonly string data;

        public MyAttribute(string text, string data)
        {
            this.text = text;
            this.data = data;
        }

        public void Method()
        {
            Console.WriteLine("Метод класса Атрибута.");
        }

        public string Text
        {
            get { return text; }
        }

        public string Data
        {
            get { return (data); }
        }
    }

    [My("XXX", "1/1/1111")]
    class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Ctor BaseClass!!!");
        }
    }

    [My("Hello!", "31/01/2008")]
    [My("World!", "31/01/2009")]
    class MyClass : BaseClass
    {
    }

    class Program
    {
        static void Main()
        {
            // MemberInfo - абстрактный класс, используется для получения информации о членах класса. 
            MemberInfo type = typeof(MyClass);


            object[] attributes = type.GetCustomAttributes(typeof(MyAttribute), true);

            if (attributes.Length != 0)
            {
                foreach (MyAttribute attribute in attributes)
                {
                    Console.WriteLine(attribute.Text);
                    Console.WriteLine(attribute.Data);
                    attribute.Method();
                }
            }

            Console.ReadKey();
        }
    }

}

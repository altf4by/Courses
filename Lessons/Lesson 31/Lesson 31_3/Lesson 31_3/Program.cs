using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_31_3
{
    class Program
    {
        static void Main()
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("CarLibrary");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            Type type = assembly.GetType("CarLibrary.MiniVan");

            object instance = Activator.CreateInstance(type);

            MethodInfo method = type.GetMethod("Acceleration");

            method.Invoke(instance, null);

            method = type.GetMethod("Driver");

            object[] parameters = { "Shumaher", 36 };

            method.Invoke(instance, parameters);

            Console.ReadKey();
        }
    }

}

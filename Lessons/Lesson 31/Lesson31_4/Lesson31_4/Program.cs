using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson31_4
{
    class Program
    {
        static void Main()
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("CarLibrary");

                Type type = assembly.GetType("CarLibrary.MiniVan");

                ICar carInstance = Activator.CreateInstance(type) as ICar;

                if (carInstance != null)
                {
                    carInstance.Acceleration();

                    carInstance.Driver("Shumaher", 26);
                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }
    }

}

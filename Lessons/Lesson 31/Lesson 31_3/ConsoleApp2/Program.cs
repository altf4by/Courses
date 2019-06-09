using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("CarLibrary");
                Type type = assembly.GetType("CarLibrary.MiniVan");

                dynamic carInstance = Activator.CreateInstance(type);
                carInstance.Acceleration();
                carInstance.Driver("Shumaher", 26);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }

}

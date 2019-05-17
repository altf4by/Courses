using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Delete_directory
{
    class Program
    {
        static void Main()
        {
            string[] drives = Directory.GetLogicalDrives();
            Console.WriteLine("Имеющиеся диски:");

            foreach (string drive in drives)
                Console.WriteLine("- {0}", drive);

            DirectoryInfo directory = new DirectoryInfo(@"C:\");

            Console.WriteLine("\nГотовимся удалять:\n");
            Console.WriteLine(directory.FullName + @"\MyDir\SubMyDir");
            Console.WriteLine(directory.FullName + @"\SUBDIR");
            Console.WriteLine("\nНажмите Enter для удаления.\n");
            Console.ReadKey();

            try
            {

                Directory.Delete(@"C:\SUBDIR");

                Directory.Delete(@"C:\MyDir", true);

                Console.WriteLine("Каталоги успешно удалены.");
            }
            catch (IOException e) { Console.WriteLine(e.Message); }


            Console.ReadKey();
        }

    }
}

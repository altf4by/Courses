using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Windows\assembly");

            if (directory.Exists) // Если указанная директория существует, то выводим о ней информацию.
            {
                Console.WriteLine("FullName      : {0}", directory.FullName);              // Полное Имя директории, (включая путь).
                Console.WriteLine("Name          : {0}", directory.Name);                  // Имя директории, (НЕ включая путь).
                Console.WriteLine("Parent        : {0}", directory.Parent);                // Родительская директория. 
                Console.WriteLine("CreationTime  : {0}", directory.CreationTime);          // Время создания директории.
                Console.WriteLine("Attributes    : {0}", directory.Attributes.ToString()); // Аттрибуты.
                Console.WriteLine("Root          : {0}", directory.Root);                  // Корневой диск, на котором находится директория.
                Console.WriteLine("LastAccessTime: {0}", directory.LastAccessTime);        // Время последнего доступа к директории.
                Console.WriteLine("LastWriteTime : {0}", directory.LastWriteTime);         // Время последнего изменения файлов в директории.            
            }
            else
            {
                Console.WriteLine("Директория с именем: {0}  не существует.", directory.FullName);
            }

            Console.ReadKey();
        }
    }
}

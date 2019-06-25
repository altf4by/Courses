using System;
using System.Diagnostics;

namespace ConsoleApplication2
{

    class Program
    {
        static void Main(string[] args)
        {
            Process newProc = Process.Start("wordpad.exe");

            Console.WriteLine("Новый процесс стартовал.");

            newProc.WaitForExit();// ожидание завершения процесса

            newProc.Close(); //освобождение памяти

            Console.WriteLine("Новый процесс завершился.");

            Console.ReadKey();
        }
    }
}

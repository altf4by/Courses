using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Process newProc = Process.Start("wordpad.exe");

            Console.WriteLine("Новый процесс стартовал.");

            if (newProc.WaitForExit(10000))
            {
                newProc.Close();
                Console.WriteLine("!!!");
            }
            else
            {
                Console.WriteLine("Больше времени прошло");
                newProc.Kill();
            }

            Console.ReadKey();
        }
    }

}

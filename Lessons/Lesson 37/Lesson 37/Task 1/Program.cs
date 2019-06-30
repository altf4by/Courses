using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static string path = @"C:\log.txt";
        static void CreateFile()
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            else
            {
                Thread trd = Thread.CurrentThread;
                trd.Abort();
            }
        }
        static void GetAccess()
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            else
            {


                Thread trd = Thread.CurrentThread;
                trd.Abort();
            }
        }
        static void Main(string[] args)
        {
            Semaphore smf = new Semaphore(2, 2);


            for (int i = 0; i < 10; i++)
            {
                Thread tread = new Thread(GetAccess);
                tread.Start();
            }

            smf.

        }
    }
}

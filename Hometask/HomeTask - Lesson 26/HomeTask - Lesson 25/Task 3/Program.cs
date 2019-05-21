using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo file = new FileInfo(@"C:\temmmmmp.txt");
            //FileStream stream = file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            StreamWriter wr = file.AppendText();
            wr.WriteLine("Hello World");
            wr.WriteLine("Hello World");
            wr.WriteLine("Hello World");
            wr.WriteLine("Hello World");
            wr.WriteLine("Hello World");

            wr.Close();
            //stream.Close();

            string s;

            StreamReader sr = file.OpenText();
            
            Console.WriteLine(sr.ReadToEnd());
            string[] mas = { "232", "213", "3333" };
            File.WriteAllLines(@"C:\t.txt",mas);

            string[] mas2 = File.ReadAllLines(@"C:\t.txt");
            foreach (var m in mas2)
            {
                Console.WriteLine(m);
            }

            Console.WriteLine(Array.IndexOf(mas, "232"));


            string[] mas3 = (Console.ReadLine().Split(' '));

            Console.ReadKey();
        }
    }
}

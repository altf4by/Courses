using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();


            switch (day)
            {
                case "Monday": 
                case "Tuesday": 
                case "Wednesday": 
                case "Thurstday": 
                case "Friday": Console.WriteLine("Working day"); break;
                case "Saturday": 
                case "Sunday": Console.WriteLine("Weekend"); break;
                // проваливание в свиче
                default: Console.WriteLine("Error");break;
            }

            Console.ReadKey();
        }
    }
}

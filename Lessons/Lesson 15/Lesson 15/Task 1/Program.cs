using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;

            DateTime dd = new DateTime(2019,6,16);
            Console.WriteLine("{0:d}",dd);
            Console.WriteLine("{0:D}", dd);
            Console.WriteLine("{0}", dd.ToShortDateString());
            Console.WriteLine(dd.ToString("yy/MM/dd"));

            Console.WriteLine(dateTime);
            Console.WriteLine(utcDate);

            TimeSpan timeSpan = dd - DateTime.Now;
            Console.WriteLine(timeSpan);
            Console.WriteLine(timeSpan.Hours);
            Console.WriteLine(timeSpan.TotalHours);

            Console.WriteLine(DateTime.Now.AddDays(86));

            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(dateTime.DayOfYear);

            Console.ReadKey();

        }
    }
}

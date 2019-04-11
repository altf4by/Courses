using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4__date_
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date(new DateTime(2019, 6, 16));
            Date date2 = new Date(new DateTime(2019, 5, 17));


            int days = date1 - date2;
            Console.WriteLine(days);

            Console.ReadKey();
        }
    }
}

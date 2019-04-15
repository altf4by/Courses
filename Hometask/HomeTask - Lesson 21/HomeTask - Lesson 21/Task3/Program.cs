using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            Site site = new Site(new Administrator(), new Editor(), new Guest());

            site.Display();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ep = new EventProvider();
            var hp = new HandlerProvider();


            ep.SomeEvent += hp.SomeMethod;

            ep.SomeEvent += hp.SomeMethod;
            ep.SomeEvent += Handler1;


            Console.ReadKey();

        }

        static void Handler1(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static double Method(int y, int z) => Math.Pow(y, z);

        static void Main(string[] args)
        {

            var item = new { Age = 78 };

            var x = 78;

            var result = Method(x, 2);

            foreach (var i in new[] { item,item})
            {

            }
        }
    }
}

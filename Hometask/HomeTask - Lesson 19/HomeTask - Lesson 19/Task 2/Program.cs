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
            Organization org = new Organization(5);

            Console.Write("Please, enter required experience in years: ");
            int exp = Int32.Parse(Console.ReadLine());

            org.DisplayExperiencedWorked(exp);

            Console.ReadKey(true);
        }

        //static void FillOrganization (Organization)
    }
}

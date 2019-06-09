using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите строку");
            var str = Console.ReadLine();
            int i = 1;
            var query = from s in str
                        where s.Equals(str[str.Length - i++])
                        select s;

            Console.WriteLine("{0}", query.Last() == str[str.Length - 1] ? "Палиндромом" : "не Палиндромом");



            Console.ReadKey();

        }
    }
}

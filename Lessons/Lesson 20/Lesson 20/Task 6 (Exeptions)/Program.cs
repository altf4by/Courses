using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6__Exeptions_
{
    class Program
    {
        static void Main()
        {
            Exception ex = new Exception("Мое Исключение");

            try
            {
                throw ex;
            }
            catch (Exception e)
            {
                Console.WriteLine("Обработка исключения.");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

    }
}

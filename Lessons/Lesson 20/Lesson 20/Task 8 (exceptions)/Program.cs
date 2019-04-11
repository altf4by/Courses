using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8__exceptions_
{
    class UserException : Exception
    {
        public void Method()
        {
            Console.WriteLine("Мое Исключение!");
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                throw new UserException();
            }
            catch (UserException e)
            {
                Console.WriteLine("Обработка исключения.");
                e.Method();
            }

            Console.ReadKey();
        }
    }

}

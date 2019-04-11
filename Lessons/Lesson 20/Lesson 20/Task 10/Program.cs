using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    public class ClassWithException
    {
        public void ThrowInner()
        {
            throw new Exception("Это внутреннее исключение!");
        }

        public void CatchInner()
        {
            try
            {
                this.ThrowInner();
            }
            catch (Exception e)
            {
                throw new Exception("Это внешнее исключение!", e);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            ClassWithException instance = new ClassWithException();
            //instance.CatchInner(); // Попробовать вызвать.
            try
            {
                instance.CatchInner();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception caught: {0}", exception.Message);
                Console.WriteLine("Inner Exception : {0}", exception.InnerException.Message);
            }

            Console.ReadKey();
        }
    }

}

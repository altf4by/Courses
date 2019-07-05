using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee();
            em.SampleEvent += M1;
            em.SampleEvent += M2;

            em.RaiseSampleEventRobust();

            Console.ReadKey();
        }

        static void M1(object sender, EventArgs e)
        {
            throw new DivideByZeroException("Деление на ноль.");
            Console.WriteLine("First");
        }

        static void M2(object sender, EventArgs e)
        {
            Console.WriteLine("Second");
        }
    }

    public class Employee
    {
        public event EventHandler SampleEvent = delegate { };

        public virtual void RaiseSampleEvent()
        {
            SampleEvent(this, EventArgs.Empty);
        }

        public virtual void RaiseSampleEventRobust()
        {
            var exceptions = new List<Exception>();

            foreach (EventHandler handler in SampleEvent.GetInvocationList())
            {
                try
                {
                    handler.Invoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                }
            }

            if (exceptions.Any())
            {
                throw new AggregateException(exceptions);
            }
        }
    }

}

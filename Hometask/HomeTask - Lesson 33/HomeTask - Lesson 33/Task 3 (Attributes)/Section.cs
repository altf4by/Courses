using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3__Attributes_.Workers;

namespace Task_3__Attributes_
{
    class Section
    {

        public void AllowAcces(Worker worker)
        {
            Type type = worker.GetType();

            object[] attributes = type.GetCustomAttributes(false);

            foreach (var attribute in attributes)
            {
                switch (((AccessLevelAttribute)attribute).Access)
                {

                    case AccessLevelAttribute.AccessLevel.Full:
                        Console.WriteLine("{0}, you are allowed to have full access!",worker.Name);
                        break;
                    case AccessLevelAttribute.AccessLevel.Partial:
                        Console.WriteLine("{0}, you are allowed to have partial access!", worker.Name);
                        break;
                    case AccessLevelAttribute.AccessLevel.Denied:
                        Console.WriteLine("{0}, sorry, you don't have an access!", worker.Name);
                        break;
                }
            }
            
        }
    }
}

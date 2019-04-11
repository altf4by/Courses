using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Motorcycle
    {
        public int driverIntensity;
        public string driverName;
        public void PopAWheely()
        {
            for (int i = 0; i < driverIntensity; i++)
                Console.WriteLine("Yeeeeeeee Haaaaaaaaw!!! ");
        }

        public Motorcycle()
        {
        }

        public Motorcycle(int intencity)
        {
            SetIntensity(intencity);
        }

        public Motorcycle(int intencity, string name) : this(intencity)
        {
            driverName = name;
        }

        public void SetDriverName(string name)
        {
            driverName = name;
        }
        public void SetIntensity(int intensity)
        {
            if (intensity > 10)
                intensity = 10;

            driverIntensity = intensity;
        }
    }
}

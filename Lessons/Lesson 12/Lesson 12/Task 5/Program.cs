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
            USD s1 = new USD(14,36);
            USD s2 = 4.77f;
            float x = (float)s1;
            s1.Show();
            s2.Show();
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
    class USD
    {
        public uint Dollars { get; private set; }
        public ushort Cents { get; private set; }

        public USD(uint dollars, ushort cents)
        {
            Dollars = dollars;
            Cents = cents;
        }

        public void Show()
        {
            Console.WriteLine($"${Dollars}.{Cents}");
        }

        public static explicit operator float (USD usd)
        {
            return usd.Dollars+0.01f*usd.Cents;
        }

        public static implicit operator USD(float value)
        {

            uint dollar = (uint)value;
            ushort cents = Convert.ToUInt16(((value - dollar)*100));
            return new USD(dollar, cents);


        }
    }

}

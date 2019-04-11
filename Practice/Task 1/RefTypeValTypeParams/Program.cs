using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeValTypeParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Person fred = new Person("Fred", 12);
            Console.WriteLine(" \nBefore bу value call , Person is : ");
            fred.Display();

            SendAPersonByValue(fred);

            Console.WriteLine(" \nAfter bу value call , Person is : ");
            fred.Display();

            Person mel = new Person("Mel", 23);

            Console.WriteLine(" \nBefore by REF call , Person is : ");
            mel.Display();

            Console.WriteLine(" \nAfter by REF call , Person is : ");
            SendAPersonByReference(ref mel);
            mel.Display();

            Console.ReadKey();

        }

        static void SendAPersonByValue(Person person)
        {
            person.personAge = 99;
            person = new Person("Nicky",99);
        }

        static void SendAPersonByReference(ref Person p)
        {
            p.personAge = 555;
            p = new Person("Nikky", 999);
        }
    }
}

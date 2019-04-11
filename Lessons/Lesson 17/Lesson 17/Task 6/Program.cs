using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    interface IStudent
    {
        void WriteLection();

        void ListenTeacher();
    }

    interface IHome
    {
        void PlasyPS();
    }

    class Person : IStudent, IHome
    {
        public void ListenTeacher()
        {
            throw new NotImplementedException();
        }

        
        public void WriteLection()
        {
            throw new NotImplementedException();
        }

        void IHome.PlasyPS()
        {
            Console.WriteLine("Interface");
        }
        public void PlasyPS()
        {
            Console.WriteLine("public");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            IStudent student = new Person();

            Person person = new Person();

            (person as IHome).PlasyPS();
            person.PlasyPS();

            Console.ReadKey();
        }
    }
}

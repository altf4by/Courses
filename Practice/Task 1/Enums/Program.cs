using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpType emp = EmpType.Contractor;
            
        }

        static void AskForBonus(EmpType emp)
        {
            switch (emp)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine(" You have got to Ье kidding . . . ");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine(" You already get enough cash ... ");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine(" VERY GOOD, Sir ! ");
                    break;
                default:
                    break;
            }
        }
    }

    enum EmpType
    {
        Manager, Grunt, Contractor, VicePresident
    }
}

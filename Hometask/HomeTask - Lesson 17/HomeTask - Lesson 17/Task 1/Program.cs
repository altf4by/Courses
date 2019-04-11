using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler someDocument = new DOCHandler();
            AbstractHandler someDocument3 = new TXTHandler();
            AbstractHandler someDocument4 = new XMLHandler();

            WorkWithDocument(someDocument);
            Console.WriteLine();

            WorkWithDocument(someDocument3);
            Console.WriteLine();

            WorkWithDocument(someDocument4);
            Console.WriteLine();

            Console.ReadKey();
        }

        static void WorkWithDocument(AbstractHandler document)
        {
            if (document != null)
            {
                ((AbstractHandler)document).Create();
                ((AbstractHandler)document).Open();
                ((AbstractHandler)document).Change();
                ((AbstractHandler)document).Save();
            }
            else
            {
                Console.WriteLine("Can't work with that file format");
            }
        }
    }
}

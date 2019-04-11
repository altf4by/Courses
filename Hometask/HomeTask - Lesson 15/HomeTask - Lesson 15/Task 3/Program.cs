using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ключ доступа: ");

            DocumentWorker dw = ChooseVersion(Console.ReadLine());
            dw.OpenDocument();
            dw.EditDocument();
            dw.SaveDocument();

            Console.ReadKey();
        }

        static DocumentWorker ChooseVersion(string key)  
        {
            DocumentWorker dw;

            switch (key.ToLower())
            {
                case "pro": dw = new ProDocumentWorker(); break;
                case "exp": dw = new ExpertDocumentWorker(); break;
                default:
                    dw = new DocumentWorker();
                    break;
            }
            return dw;
        }
    }
}

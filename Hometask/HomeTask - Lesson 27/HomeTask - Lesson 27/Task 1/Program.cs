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
            KeyBoardController controller = new KeyBoardController();
            Logger logger = new Logger();

            controller.KeyPressed += logger.CollectPressedKeys;
            controller.StopKeyPressed += logger.SaveResultsToFile;

            controller.Start();

            Console.ReadKey();
        }
    }
}

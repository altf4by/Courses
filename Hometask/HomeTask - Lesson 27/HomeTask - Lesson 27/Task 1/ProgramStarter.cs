using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class ProgramStarter
    {
        public ProgramStarter(KeyBoardController controller)
        {
            Start(controller);
        }

        private void Start(KeyBoardController controller)
        {
            ConsoleKey key;
            int counter = 0;

            Console.WriteLine("Start printing, till \".\" not pressed");
            do
            {
                key = Console.ReadKey().Key;
                counter++;

                controller.RunKeyPressed(key);

                //KeyPressed?.Invoke(this, key);
            } while (key != ConsoleKey.OemPeriod);

            controller.RunStopKeyPressed(counter);
            //StopKeyPressed?.Invoke(this, counter);
        }
    }
}

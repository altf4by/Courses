using System;

namespace Task_1
{
    class ProgramStarter
    {
        public void Start(KeyBoardController controller)
        {
            ConsoleKey key;
            int counter = 0;

            Console.WriteLine("Start printing, till \".\" not pressed");
            do
            {
                key = Console.ReadKey().Key;
                counter++;

                controller.RunKeyPressed(key);

            } while (key != ConsoleKey.OemPeriod);

            controller.RunStopKeyPressed(counter);
        }
    }
}

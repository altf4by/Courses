using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class KeyBoardController
    {
        public void Start()
        {
            char ch;
            int counter = 0;

            Console.WriteLine("Start printing, till \".\" not pressed");

            do
            {
                ch = Console.ReadKey().KeyChar;
                counter++;

                KeyPressed(this, ch);

            } while (ch != 46);

            StopKeyPressed(this, counter);
        }

        public event EventHandler<char> KeyPressed;
        public event EventHandler<int> StopKeyPressed;
    }
}

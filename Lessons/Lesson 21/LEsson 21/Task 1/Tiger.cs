using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Tiger : IWildCat
    {
        public string Breed { get { return "Тигр обыкновенный"; } }

        public void Growl()
        {
            Console.WriteLine("Grrrrrrr");
        }

        public void Scratch()
        {
            Console.WriteLine("У меня очень острые когти, царапаюсь до смерти");
        }
    }

}

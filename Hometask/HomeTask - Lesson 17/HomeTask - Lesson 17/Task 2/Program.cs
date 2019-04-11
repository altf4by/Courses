using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            WorkAsRecorder(player);
            WorkAsPlayer(player);



            Console.ReadKey();

        }

        static void WorkAsRecorder(IRecordable player)
        {
            if (player!=null)
            {
                player.Record();
                player.Pause();
                player.Stop();
            }
            else
            Console.WriteLine("Something went wrong");
        }
        static void WorkAsPlayer(IPlayable player)
        {
            if (player != null)
            {
                player.Play();
                player.Pause();
                player.Stop();
            }
            else
            Console.WriteLine("Something went wrong");
        }
    }
}

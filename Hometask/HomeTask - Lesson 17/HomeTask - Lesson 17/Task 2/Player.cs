using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Player : IRecordable, IPlayable
    {
        void IRecordable.Pause()
        {
            Console.WriteLine("PAUSE RECORDING the video");
        }

        public void Record()
        {
            Console.WriteLine("START RECORDING the video");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("STOP RECORDING the video");
        }

        public void Play()
        {
            Console.WriteLine("START PLAYING the video");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("PAUSE PLAYING the video"); ;
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("STOP PLAYING the video");
        }
    }
}

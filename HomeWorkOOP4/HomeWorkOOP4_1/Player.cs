using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP4_1
{
    class Player:IRecodable,IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Play IPlayable");
        }
         void IPlayable.Pause()
        {
            Console.WriteLine("Pause IPlayable");
        }
         void IPlayable.Stop()
        {
            Console.WriteLine("Stop IPlayable");
        }
        public void Record()
        {
            Console.WriteLine("Record Player");
        }
         void IRecodable.Pause()
        {
            Console.WriteLine("Pause IRecodable");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Stop IRecodable");
        }
    }
}

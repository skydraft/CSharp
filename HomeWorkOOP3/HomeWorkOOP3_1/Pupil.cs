using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP3_1
{
    class Pupil
    {
        
        public virtual void  Study()
        {
            Console.WriteLine("Любит учиться");
        }
       public virtual void Read()
        {
            Console.WriteLine("Любит читать");
        }
        public virtual void Write()
        {
            Console.WriteLine("Любит писать");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Любит отдыхать");

        }
    }
}

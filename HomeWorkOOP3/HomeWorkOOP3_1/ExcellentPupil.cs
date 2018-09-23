using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP3_1
{
    class ExcellentPupil:Pupil
    {
        public override void Read()
        {
            Console.WriteLine("не любит читать");
        }
        public override void Study()
        {
            Console.WriteLine("не любит учиться");
        }
        public override void Write()
        {
            Console.WriteLine("не любит писать");
        }
        public override void Relax()
        {
            base.Relax();
        }
    }
}

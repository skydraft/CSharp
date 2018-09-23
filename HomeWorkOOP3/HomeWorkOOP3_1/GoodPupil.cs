using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP3_1
{
    class GoodPupil:Pupil
    {
        public override void Read()
        {
            base.Read();
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

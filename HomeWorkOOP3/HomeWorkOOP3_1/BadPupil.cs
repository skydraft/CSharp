using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP3_1
{
    class BadPupil:Pupil
    {
        public override void Read()
        {
            Console.WriteLine("class BadPupil-не любит читать");
        }
        public override void Study()
        {
            Console.WriteLine("class BadPupil-не любит учиться");
        }
        public override void Write()
        {
            Console.WriteLine("class BadPupil-не любит писать");
        }
        public override void Relax()
        {
            Console.Write("class BadPupil-");
            base.Relax();
        }
    }
}

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
            Console.Write("class GoodPupil-");
            base.Read();
        }
        public override void Study()
        {
            Console.WriteLine("class GoodPupil-не любит учиться");
        }
        public override void Write()
        {
            Console.Write("class GoodPupil-");
            base.Write();
        }
        public override void Relax()
        {
            Console.Write("class GoodPupil-");
            base.Relax();
        }
    }
}

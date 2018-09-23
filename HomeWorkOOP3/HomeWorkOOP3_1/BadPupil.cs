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
            base.Read();
        }
        public override void Study()
        {
            base.Study();
        }
        public override void Write()
        {
            base.Write();
        }
        public override void Relax()
        {
            Console.WriteLine("не любит отдыхать");
        }
    }
}

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
            Console.Write("class ExcellentPupil-");
            base.Read();
        }
        public override void Study()
        {
            Console.Write("class ExcellentPupil-");
            base.Study();
        }
        public override void Write()
        {
            Console.Write("class ExcellentPupil-");
            base.Write();
        }
        public override void Relax()
        {
            Console.WriteLine("class ExcellentPupil-не любит отдыхать");
        }
    }
}

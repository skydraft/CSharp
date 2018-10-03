using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP3_1
{
    class ClassRoom
    {

       Pupil[] pupils = new Pupil[4];
     public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupils[0] = pupil1;
            pupils[1] = pupil2;
            pupils[2] = pupil3;
            pupils[3] = pupil4;
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupils[0] = pupil1;
            pupils[1] = pupil2;
            pupils[2] = pupil3;
            pupils[3] =GeneratePupil();//
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            pupils[0] = pupil1;
            pupils[1] = pupil2;
            pupils[2] = GeneratePupil();
            pupils[3] = GeneratePupil();
        }
        protected Pupil GeneratePupil()
        {
            Random random = new Random();
            int r = random.Next(1, 4);
            switch (r)
            {
                case 1:
                    return new ExcellentPupil();
                case 2:
                    return new GoodPupil();
                case 3:
                    return new BadPupil();
            }
            
            return new BadPupil();
        }
        public void Read()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.Read();
            }
            Console.WriteLine(new string('-',30));
        }

        public void Write()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.Write();
            }
            Console.WriteLine(new string('-', 30));
        }
        public void Study()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.Study();
            }
            Console.WriteLine(new string('-', 30));
        }
        public void Relax()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.Relax();
            }
            Console.WriteLine(new string('-', 30));
        }
    }
}

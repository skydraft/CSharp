using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil p1 = new BadPupil();
            Pupil p2 = new ExcellentPupil();
            Pupil p3 = new BadPupil();
            Pupil p4 = new BadPupil();
           ClassRoom classRoom = new ClassRoom(p1,p2);
            classRoom.Read();
            classRoom.Relax();
            Console.ReadKey();
            
        }
    }
}

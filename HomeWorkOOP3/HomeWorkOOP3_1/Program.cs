using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP3_1
{
    /*Задание 2 
     * Создать класс, представляющий учебный класс ClassRoom. 
     * Создайте класс ученик Pupil.  В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().
     * Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil  от класса базового класса Pupil 
     * и переопределите каждый из методов, в зависимости от успеваемости ученика. 
     * Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников. 
     * Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента. 
     * Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать. 
     * */
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

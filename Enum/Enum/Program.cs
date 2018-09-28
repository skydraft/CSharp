using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    /*В пространство имен поместите перечисление MyEnum со следующими элементами типа ushort:
     * zero – со значением 0, one – со значением 1 и two – со значением 2.
     * Затем в классе Program реализуйте метод isEnumValueDefined, который должен возвращать true,
     * если подаваемая на вход метода константа существует в MyEnum, иначе – возвращать false.
    */

    //создаем перечисление
    enum MyEnum : ushort
    {
        zero = 0,
        one = 1,
        two = 2
    }
    class Program
    {
        static void Main(string[] args)
        {
            ushort u1 = 1;
            ushort u2 = 2;
            ushort u3 = 3;

            Console.WriteLine(isEnumValueDefined(u1)); //true
            Console.WriteLine(isEnumValueDefined(u2)); //true
            Console.WriteLine(isEnumValueDefined(u3)); //false

            Console.ReadKey();
        }
       // метод isEnumValueDefined проверяет существует ли подоваемое значение в MyEnum
        static bool isEnumValueDefined(ushort u)
        {

            for (MyEnum number = MyEnum.one; number <= MyEnum.two; number++)
            {
                if (u >= (ushort)MyEnum.one & u <= (ushort)MyEnum.two)
                {
                    return true;
                }

            }
            return false;
        }
    }
}

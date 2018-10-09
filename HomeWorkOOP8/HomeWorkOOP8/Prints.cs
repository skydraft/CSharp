using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP8
{
    static class Prints
    {
        //создаем перечесление
        enum ColorEnum:int
        {
            Black = 0,
            DarkBlue = 1,
            DarkGreen = 2,
            DarkCyan = 3,
            DarkRed = 4,
            DarkMagenta = 5,
            DarkYellow = 6,
            Gray = 7,
            DarkGray = 8,
            Blue = 9,
            Green = 10,
            Cyan = 11,
            Red = 12,
            Magenta = 13,
            Yellow = 14,
            White = 15
        }
      public static void Print(string stroka, int color)
        {

            ColorEnum colorEnum;
            //color приводим к типу ColorEnum
            colorEnum =(ColorEnum)color;
            //передаем значение colorEnum(colorEnum приводим к типу ConsoleColor)
            Console.ForegroundColor = (ConsoleColor)colorEnum;
            //вывод строки
            Console.WriteLine(stroka);
            
            
        }
    }
}

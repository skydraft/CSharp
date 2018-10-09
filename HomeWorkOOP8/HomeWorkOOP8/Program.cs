using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP8
{
    /*Задание
     * Создайте статический класс с методом void Print (string stroka, int color),
     * который выводит на экран строку заданным цветом.
     * Используя перечисление, создайте набор цветов, доступных пользователю.
     * Ввод строки и выбор цвета предоставьте пользователю. 
     * 
     */

    

    class Program
    {
        static void Main(string[] args)
        {
            string color;
            string text;
            int colorInt;
            //запрос цвета и строки для вывода 
            Console.WriteLine("Выберите цвет(от 0 до 15)");
            color = Console.ReadLine();
            Console.WriteLine("Введите текст для вывода");
            text = Console.ReadLine();
            //проверяем на допустимые значения
            if (Int32.TryParse(color, out colorInt))
            {
                colorInt = Convert.ToInt32(color);
                if (0 <= colorInt & colorInt <= 15)
                {
                    Console.WriteLine(new string('-', 30));
                    Prints.Print(text, colorInt);
                }
                else { Console.WriteLine("Введен недопустимый цвет"); }
            }
            else { Console.WriteLine("Введен недопустимый цвет"); }
          
            Console.ReadKey();
        }
    }
}

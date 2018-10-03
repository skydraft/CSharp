using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP3
{
    class Printer
    {
        //цвет вывода в консоле
        protected ConsoleColor color;
        //создаем пользовательский конструктор
        public Printer(ConsoleColor color)
        {
            this.color = color;
        }
        //метод выводит строку выбранным цветом
        public virtual void Print(string value)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ResetColor();
           
        }
               
    }
}

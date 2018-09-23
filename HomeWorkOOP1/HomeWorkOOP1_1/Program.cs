using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("отрабатывает конструктор по умолчанию");
            Console.WriteLine("площадь прямоугольника = {0}",rectangle.Area);
            Console.WriteLine("периметер прямоугольника = {0}", rectangle.Perimeter);
            Rectangle rectangle1 = new Rectangle(3,7);
            Console.WriteLine("отрабатывает пользовательский конструктор");
            Console.WriteLine("площадь прямоугольника = {0}", rectangle1.Area);
            Console.WriteLine("периметер прямоугольника = {0}", rectangle1.Perimeter);
            Console.ReadKey();

        }
    }
}

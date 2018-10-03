using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP3
{
    /*Задание:
     * Создайте класс Printer.
     * В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента.
     *Реализуйте возможность того, чтобы в случае наследования от данного класса других классов,
     * и вызове соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов, выводились разными цветами.  
     */
         
    class Program
    {
        static void Main(string[] args)
        {
            
            PrinterColor printerColor = new PrinterColor(ConsoleColor.Yellow);
            printerColor.Print("yellow");
            
            Printer printer = new Printer(ConsoleColor.Red);
            printer.Print("red");
            
            Console.ReadKey();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Printer printer = new Printer();
            PrinterRed printerRed = new PrinterRed();
            printerRed.Print("red1");
            printerRed.Method();
            Printer printer = new Printer();

            printer.Print("while");
            printer.Method();

            Console.ReadKey();
            
        }
    }
}

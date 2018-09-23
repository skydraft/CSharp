﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP3
{
    class PrinterRed:Printer
    {
        public override void Print(string value)
        {
           // base.Print(value);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public override void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }


    }
}

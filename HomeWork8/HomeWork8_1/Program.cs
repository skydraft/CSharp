using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8_1
{
    //Факториал числа через рекурсию
    class Program
    {
       
        static int Factr(int a)
        {
            if (a <= 1)
                return 1;
            else
            {
                return a * Factr(a - 1);
            }
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine(Factr(4));
            Console.ReadKey();
        }
    }
}

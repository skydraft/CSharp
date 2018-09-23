using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    class Program
    {
        //использование модификатора ref для получения результатов функции через входные параметры.
        static int Calculate(int a,ref int b,ref int c)
        {
            b = b / 5;
            c = c / 5;
            return a/5;
            
            
        }
        static void Main(string[] args)
        {
            int a1 = 5;
            int b1 = 10;
            int c1 = 15;

            int d=Calculate(a1, ref b1,ref c1);
            
            Console.WriteLine(d);
            Console.WriteLine(b1);
            Console.WriteLine(c1);
            Console.ReadKey();
        }
    }
}

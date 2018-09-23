using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 5;
            int summ=0;
            while (a <= b)
            {
                summ += a;
                a++;
            }
            Console.WriteLine(summ);
            Console.ReadKey();
        }
    }
}

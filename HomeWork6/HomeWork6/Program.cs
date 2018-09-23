using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            //loop while
            Console.WriteLine("loop while:");
            while (a < 4)
            {
                
                while (b < 10)
                {
                    
                    Console.Write("*");
                    b++;
                }
                Console.WriteLine();
                a++;
                b = 0;
            }
            //loop for
            Console.WriteLine("loop for:");
            for (int c = 1; c <= 4; c++)
            {
                for(int d = 1; d <= 10; d++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8_4
{
    //найти НОД(наибольший общий делитель)
    
    class Program
    {
        static int Nod(int a, int b)
        {
            if (a % b == 0) { return b;
            }
            else
            {
                return Nod(b, a % b);
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(2%9);
            Console.ReadKey();
        }
    }
}

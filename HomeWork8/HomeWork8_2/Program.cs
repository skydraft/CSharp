using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8_2
{
    //преобразовать десятичное число в двоичное через рекурсию
    class Program
    {
        static void Convertts(int a)
        {
            int temp = a % 2;
            if (a >= 2)
            {
                Convertts(a / 2);
            }
            Console.WriteLine(temp);
            //мой первый вариант с возвратом из метода типа int
            /*if (a == 1)
            {
                
                Console.WriteLine(1);
                return 1;
            }
            else
            {
                Convertts(a / 2);
                Console.WriteLine(a % 2);
                return a % 2;

            }*/
            
        }
        static void Main(string[] args)
        {
            Convertts(18);
            
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            //проверяем является ли число степенью двойки//
            int x = 0;
            int s;
            Console.WriteLine("Введите число: ");
            x =Convert.ToInt32(Console.ReadLine());
            s = x & (x - 1);
            if (s==0)
                {
                Console.WriteLine(" число является степенью двойки");
            }
            else
            {
                Console.WriteLine(" число не является степенью двойки");
            }
            Console.ReadKey();
        }
    }
}

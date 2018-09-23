using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 0 до 100: ");
           // string seting = Console.ReadLine();
            int setingInt = Convert.ToInt32(Console.ReadLine());
            if (0 <= setingInt & setingInt <= 100)
            {

            
            if (0 <= setingInt & setingInt <= 14)
            {
                Console.WriteLine("число находится в диапазорне [0-14]");
            }
            if (15 <= setingInt & setingInt <= 35)
            {
                Console.WriteLine("число находится в диапазорне [15-35]");
            }
            if (36 <= setingInt & setingInt <= 50)
            {
                Console.WriteLine("число находится в диапазорне [36-50]");
            }
            if (51 <= setingInt & setingInt <= 100)
            {
                Console.WriteLine("число находится в диапазорне [51-100]");
            }
        }
            else
            {
                Console.WriteLine("число за пределами диапазона");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //проверка чисел на четность
          byte x;
            Console.WriteLine("Введите число:");
            x = Convert.ToByte(Console.ReadLine());
            byte n = (byte)(x << 7);
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}

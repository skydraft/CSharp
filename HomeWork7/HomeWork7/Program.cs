using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class Program
    {
        static void Calculate(int a,int b,int c)
        {
            Console.WriteLine((a+b+c)/3);
            
        }
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Введите первое число: ");
                int first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                int second = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите третье число: ");
                int three = Convert.ToInt32(Console.ReadLine());
                Calculate(first, second, three);
            }
            catch
            {
                Console.WriteLine("Вы ввели неизвестный параметр");
            }
            
            Console.ReadKey();
        }
    }
}

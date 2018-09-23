using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_1
{
    class Program
    {
        static void Add(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        static void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое число: ");
                int first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                int second = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите знак операции: ");
                string three = Console.ReadLine();
                switch (three)
                {
                    case "+":
                        Add(first, second);
                        break;
                    case "-":
                        Sub(first, second);
                        break;
                    case "\\":
                        if (second == 0)
                        {
                            Console.WriteLine("Делить на ноль нельзя!");
                            break;
                        }
                        else
                        {
                            Div(first, second);
                            break;
                        }
                    case "*":
                        Mul(first, second);
                        break;
                    default:
                        Console.WriteLine("Вы выбрали недопустимую операцию");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Вы ввели неизвестный параметр");
            }
            Console.ReadKey();
            
            
        }
    }
}

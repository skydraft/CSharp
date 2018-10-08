using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP6
{
    static class Calculator
    {
        //Статический метод сложения
        public static void Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a,b, a + b);
        }
        //Статический метод вычитания
        public static void Subtraction(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        //Статический метод умножения
        public static void Multiply(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
        //Статический метод деления
        public static void Division(int a, int b)
        {
            if (b != 0)
            { 
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            }
            Console.WriteLine("деление на ноль невозможно");
        }
    }
}

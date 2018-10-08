using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP6
{
    /*Задание :
     * Создать статический класс Calculator, с методами для выполнения основных арифметических операций. 
     *Написать программу, которая выводит на экран основные арифметические операции. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            //методы принимают только int значения,обработка исключений не реализована
            Calculator.Add(5, 3);
            Calculator.Subtraction(5, 3);
            Calculator.Division(5, 0);
            Calculator.Multiply(5, 3);
            Console.ReadKey();
        }
    }
}

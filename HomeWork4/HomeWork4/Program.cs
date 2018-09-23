using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 2;
            int operand2 = 3;
            string sign = "";
            Console.WriteLine("Введите знак арифметического действия(+,-,*,/): ");
            sign=Console.ReadLine();
            switch (sign)
            {
                case "+": Console.WriteLine("{0} + {1} = {2}", operand1, operand2,operand1 + operand2);
                    break;
                case "-":
                    Console.WriteLine("{0} - {1} = {2}", operand1, operand2, operand1 - operand2);
                    break;
                case "*":
                    Console.WriteLine("{0} * {1} = {2}", operand1, operand2, operand1 * operand2);
                    break;
                case "/":
                    if (operand2 == 0) {
                        Console.WriteLine("Делить на ноль нельзя!");

                        break; }
                    else
                    {
                        Console.WriteLine("{0} / {1} = {2}", operand1, operand2, operand1 / operand2);
                        break;
                    }
                default: Console.WriteLine("неизвестная операция");
                    break;
            }
            Console.ReadKey();
        }

    }
}

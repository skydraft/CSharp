using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP9
{
    /*Задание 
     * Создайте анонимный метод, который принимает в качестве параметров три целочисленных аргумента
     * и возвращает среднее арифметическое этих аргументов. 
     */
     //создаем клавсс делегата 
    delegate double MiddleSum(double a, double b, double c);
    class Program
    {
        static void Main(string[] args)
        {
            //создаем экземпляр класса-делегата MiddleSum и сообщаем с ним анонимный метод
            MiddleSum middleSum = delegate (double a, double b, double c) { return (a + b + c) / 3; };
            //вызываем анонимный метод
            Console.WriteLine(middleSum(3.2,3,3));

            Console.ReadKey();
                 
        }
    }
}

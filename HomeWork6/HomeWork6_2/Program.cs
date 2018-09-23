using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //прямоугольник

            Console.WriteLine("Прямоугольник:");
            for (int c = 1; c <= 4; c++)
            {
                for (int d = 1; d <= 10; d++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Треугольник:");
            for (int c = 1; c <= 4; c++)
            {
                for (int d = 1; d <= c; d++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Равносторонний треугольник:");
            int count = 4; //счетчик отступов
            for (int c = 1; c <= 4; c++) 
            {
                 //цикл отступов открая               
                for (int s = count; s >= 1; s--)
                {
                    Console.Write(" ");
                }
                //рисуем звездочки
                for (int d = 1; d <= c; d++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                count--;
                Console.Write("\n");
            }
            Console.WriteLine("Ромб:");
            int count1 = 3; //счетчик отступов для верхней части
            int count2 = 2; //счетчик отступов для нижней части
           //рисуем верхнию часть ромба
            for (int c = 1; c <= 3; c++)
            {
                //цикл отступов открая               
                for (int s = count1; s >= 1; s--)
                {
                    Console.Write(" ");
                }
                //рисуем звездочки
                for (int d = 1; d <= c; d++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                count1--;
                Console.Write("\n");
            }
            //рисуем нижнию часть ромба
            for (int c=3;c>=1;c--)
            {
                for (int s = count2; s <= 3; s++)
                {
                    Console.Write(" ");
                }

                for (int d = 1; d < c; d++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                count2--;
                Console.Write("\n");
            }
            Console.ReadKey();

        }
    }
}

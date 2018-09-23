using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_2
{
    class Program
    {
        static void TestCh(double a)
        {
            if (a > 0)
            {
                Console.WriteLine("{0} положительное число",a);
            }
            else
            {
                Console.WriteLine("{0} отрицательное число", a);
            }


        }
        static void TestCh1(double a)
        {
            double ostatok = 0;
            int summ_count = 0;
            for(int i = 1; i <= 9; i++)
            {
                ostatok = a % i;
                if (ostatok == 0) {
                    summ_count = summ_count + 1;
                        }
            }
            if  (a> 9)
            {
                summ_count++;
            }
            if (summ_count == 2)
            {
                Console.WriteLine("{0} простое число",a);
            }
            else
            {
                Console.WriteLine("{0} составное число", a);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число отличное от 0");
            double digital = Convert.ToDouble(Console.ReadLine());
            TestCh(digital);//отрицательное или положительное число

            TestCh1(digital);//простое или составное число
            Console.ReadKey();
        }
    }
}

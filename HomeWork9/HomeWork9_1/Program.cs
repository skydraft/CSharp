using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9_1
{
    class Program
    {
        //наибольшее значение массива
        static int MaxArray(int [] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        //наименьшее значение массива
        static int MinArray(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }
        //Общая сумма всех элементов
        static int SummArray(int[] array)
        {
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                summ = summ + array[i];
            }
            return summ;
        }
        //среднее арифметическое значение всех элементов
        static double MiddleArifmetArray(int[] array)
        {
            double summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                summ = summ + array[i];
            }
            return summ/array.Length;
        }

        //все нечетные элементы массива
        static void NechetArray(int[] array)
        {
            int a = 0;
            Console.Write("все нечетные элементы массива: ");
            for (int i = 0; i < array.Length; i++)
            {
                a = array[i] % 2;
                if (a == 1)
                {
                    Console.Write("{0} ",array[i]);
                }
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер одмомерного массива: ");

                     
            int[] array = new int [Convert.ToInt32(Console.ReadLine())];

            Random rnd = new Random();
            //заполняем массив случайными числами
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100);
            }
            //выводим массив на экран
            Console.Write("массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ",array[i]); ;
            }
            Console.WriteLine("\n");
            //-------------------------------------------------------------------------
            Console.WriteLine("наибольшее значение массива = {0}", MaxArray(array));
            Console.WriteLine("наименьшее значение массива = {0}", MinArray(array));
            Console.WriteLine("общая сумма всех элементов = {0}", SummArray(array));
            Console.WriteLine("среднее арифметическое значение всех элементов = {0}", MiddleArifmetArray(array));
            NechetArray(array);
            Console.ReadKey();

        }
    }
}


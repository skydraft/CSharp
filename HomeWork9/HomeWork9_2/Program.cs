using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9_2
{
    class Program
    {

        //возвращает инвертированный массив
        static int[] MyRevers(int [] array)
        {
            int[] reversArray=new int [array.Length];
            int count = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversArray[count] = array[i];
                count++;
            }
            return reversArray;
        }
         //выводит массив на экран
        static void PrintArray(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]); ;
            }
            Console.WriteLine("\n");
        }
        //копирование массива и вставка в новый
        static int[] SubArray(int[] array,int index,int count)
        {
            
            //count размер массива
            int[] subArray = new int[count];
            int count1 = index;
            for (int ii = 0; ii < subArray.Length; ii++)
            {
                
                 if (count1 > array.Length-1)
                {
                    subArray[ii] = 1;
                }
                else
                {
                    subArray[ii] = array[count1];
                }
                
                count1++;
            }
            return subArray;
        }
        //------------------------------------
        //добавление в начало массива нового элемента 
        static int[] NewArray(int[] array, int value)
        {
            int newCount = array.Length + 1;
            int[] newArray = new int[newCount];
            newArray[0] = value;
            int count = 0;
            for (int i = 1; i < newArray.Length; i++)
            {
                newArray[i] = array[count];
                count++;
                
            }
            return newArray;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер одмомерного массива: ");


            int[] array = new int[Convert.ToInt32(Console.ReadLine())];

            Random rnd = new Random();
            //заполняем массив случайными числами
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100);
            }
            //выводим массив на экран
            Console.Write("массив: ");
            PrintArray(array);
            //выводим обратный массив на экран
            int[] reversArray =new int [array.Length];
            reversArray = MyRevers(array);
            Console.Write("обратный массив: ");
            PrintArray(reversArray);
            //---------------------------------------------------------------------
            Console.WriteLine("укажите индекс с которого хотите начать копировать массив: ");
            int inIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("укажите колличество элементов которые хотите скопировать: ");
            int inCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("новый массив: ");
            PrintArray(SubArray(array, inIndex, inCount));
            //---------------------------------------------------------------------
            Console.WriteLine("укажите какое число ходите вставить в начало массива: ");
            int inValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("новый массив: ");
            PrintArray(NewArray(array, inValue));

            Console.ReadKey();
        }
    }
}

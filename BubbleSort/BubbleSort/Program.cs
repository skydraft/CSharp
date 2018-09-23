using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]sort = { 2, 4,6,5,9,0  };
            //выводим массив на экран  
            Console.Write("исходный массив: ");
            for (int m = 0; m < sort.Length; m++)
            {
                Console.Write(sort[m]);

            }
            Console.WriteLine("\n");

            Console.Write("отсортированный массив: ");
            //сортируем массив
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.SortArray(sort);
         
            Console.ReadKey();

        }
    }
}

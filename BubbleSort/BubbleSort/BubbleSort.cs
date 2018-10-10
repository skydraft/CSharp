using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class BubbleSort
    {
        TimeSpan resultTime;
        //первый вариант сортировки
        int[] BubbleSorts(int[] sortArray, ref TimeSpan resultTime)
        {

            var startTime = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < sortArray.Length; i++)
            {
                for (int j = 0; j < sortArray.Length - 1; ++j)
                {
                    if (sortArray[j] > sortArray[j + 1])
                    {
                        int temp = sortArray[j];
                        sortArray[j] = sortArray[j + 1];
                        sortArray[j + 1] = temp;
                    }
                }
            }
            startTime.Stop();
            resultTime = startTime.Elapsed;
            return sortArray;
        }
        //второй вариант сортировки
        int[] BubbleSortsV2(int[] sortArray, ref TimeSpan resultTime)
        {
            var startTime = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < sortArray.Length; i++)
            {
                for (int j = 0; j < sortArray.Length ; ++j)
                {
                    if (sortArray[i] > sortArray[j])
                    {
                        int temp = sortArray[j];
                        sortArray[j] = sortArray[i];
                        sortArray[j] = temp;
                    }
                }
            }
            startTime.Stop();
            resultTime = startTime.Elapsed;
            return sortArray;
        }
        //вывод на экран упорядоченный массив и время выполнения сортировки
        //используя метод BubbleSorts
        public void SortArray(int [] uSortArray)
        {
            int[] sortArray = BubbleSorts(uSortArray,ref resultTime);
            for (int m = 0; m < sortArray.Length; m++)
            {
                Console.Write(sortArray[m]);

            }
            Console.WriteLine("");
            Console.WriteLine("время выполнения сортировки: {0}", resultTime);
            
        }
        //вывод на экран упорядоченный массив и время выполнения сортировки
        //используя метод BubbleSortsV2
        public void SortArrayV2(int[] uSortArray)
        {
            int[] sortArray = BubbleSortsV2(uSortArray, ref resultTime);
            for (int m = 0; m < sortArray.Length; m++)
            {
                Console.Write(sortArray[m]);

            }
            Console.WriteLine("");
            Console.WriteLine("время выполнения сортировки: {0}", resultTime);
          
        }
    }
}

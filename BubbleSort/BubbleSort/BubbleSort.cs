using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class BubbleSort
    {
      
        int[] BubbleSorts(int[] sortArray)
        {
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
            return sortArray;
        }
        public void SortArray(int [] uSortArray)
        {
            int[] sortArray = BubbleSorts(uSortArray);
            for (int m = 0; m < sortArray.Length; m++)
            {
                Console.Write(sortArray[m]);

            }
            
        }

    }
}

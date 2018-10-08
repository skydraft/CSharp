using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP6_1
{
    static class SortBubble
    {
        //расширяющий метод,сортировка массива
       public static void Sort(this int[] matrix)
        {
            
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    if (matrix[i] < matrix[j])
                    {
                        int t = matrix[i];
                        matrix[i] = matrix[j];
                        matrix[j] = t;
                    }
                }
            }
        }
    }
}

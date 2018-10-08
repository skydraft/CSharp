using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP6_1
{
    class Program
    {
      /*Задание 
       *создать расширяющий метод для целочисленного массива, который сортирует элементы массива по возрастанию.
       */
  
        static void Main(string[] args)
        {
            int[] matrix = { 3, 2, 6, 3, 8, 4, 9 };
            int[] matrix2 = { 3, 2, 6, 3, 8, 4, 9 };
            //вызов расширяющего метода вариант 1
            SortBubble.Sort(matrix);
            //вызов расширяющего метода вариант 2
            matrix2.Sort();

            foreach (int i in matrix)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(new string('-',30));

            foreach (int i in matrix2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}

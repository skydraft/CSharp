using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    class Program
    {
        //Вывесьт массив в обратном порядке
        static void Main(string[] args)
        {
            int[] array= new int[10];
            //заполняем массив от 0 до 9
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            //выводим массив в обратном порядке
            for (int i = array.Length-1; i >= 0; i--)
            {
                Console.Write("{0} ",array[i]);
            }
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    /*Заполните словарь dict парами 1 – «one» .. 4 – «four» и выведите их на экран в формате «ключ-значение».
     * Диапазон ключей для вывода – 0..10 включительно. В случае, если какому-то ключу не присвоено значение
     * – вывести соответствующее сообщение "i has no value", где i - ключ
     * */
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");
            dict.Add(4, "four");
            for (int i = 0; i <= 10; i++)
            {
                if (dict.ContainsKey(i)) { Console.WriteLine(i + "-" + dict[i]); }
                else
                {
                    Console.WriteLine(i + " has no value");
                }

            }
            Console.ReadKey();
        }
    }
}


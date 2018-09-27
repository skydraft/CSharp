using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndexers_virtual_
{
    class ProtectedIndexer
    {
        //создание массива
        string[] pArray = new string[3] { "one", "two", "three" };
        //реализация индексатора с проверкой выхода индекса за диапазон массива 
        public string this[int index]
        {
            get
            {
                
                if (index >= 0 & index < pArray.Length)
                {
                    return pArray[index];
                }
                else
                {
                    return "get:index out of range";
                }
            }
            set
            {

                if (index >= 0 & index < pArray.Length)
                {
                    pArray[index] = value;
                }
                else
                {
                    Console.WriteLine("set:index out of range");
                }

            }
        }
    }
}

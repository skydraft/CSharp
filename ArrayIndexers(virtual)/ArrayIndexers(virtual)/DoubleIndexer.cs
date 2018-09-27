using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndexers_virtual_
{
    class DoubleIndexer
    {
        //создание массива
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //двумерный индексатор с методом доступа get, который принимать целочисленный и строковой индексы
        //и возвращать конкатенацию строкового индекса и соответствующего элемента массива
        public string this[int index1, string index2]
        {
            get
            {

                return  array[index1-1]+ index2;
            }

        }
    }
}

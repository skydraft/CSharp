using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP9_2
{
    /* Задание  
     * Создайте анонимный метод, который принимает в качестве аргумента массив делегатов
     * и возвращает среднее арифметическое возвращаемых значений методов сообщенных с делегатами в массиве.
     * Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int.
     */
    delegate int DelArray(int[] arrays);
    delegate int AllArray(DelArray[] allArrays);
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] myArray =  { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            DelArray delArray0;
            delArray0 = (arrays)=>{ int i = random.Next(0, 8); return arrays[i]; };
            delArray0.Invoke(myArray);
            DelArray delArray1;
            delArray1 = (arrays) => { int i = random.Next(0, 8); return arrays[i]; };
            delArray1.Invoke(myArray);
            DelArray delArray3;
            delArray3 = (arrays) => { int i = random.Next(0, 8); return arrays[i]; };
            delArray3.Invoke(myArray);
            DelArray[] delArrays = { delArray0, delArray1, delArray3 };
            // AllArray allArray = (delArrays) => { return (delArray0 + delArray1 + delArray3) / 3; };
            Console.ReadKey();
        }
    }
}

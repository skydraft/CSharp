using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP9_2
{
    /* Задание  
     * Создайте анонимный метод, который принимает в качестве аргумента массив делегатов
     * и возвращает среднее арифметическое возвращаемых значений методов сообщенных с делегатами в массиве.
     * Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int.
     */
    delegate int DelRendom();
   
    delegate double AllArray(DelRendom[] allArrays);
    class Program
    {
        private static Random random = new Random();
         static int MyRendom()=> random.Next(100);
   
       
        static void Main(string[] args)
        {
           // создаем массив с делегатами
            var arrays = new DelRendom[3];
            for (int i = 0; i < arrays.Length; i++)
            {

                //запись arrays[i]= MyRendom; аналогична arrays[i] = ()=>new DelRendom(MyRendom).Invoke();
                arrays[i]= () => new DelRendom(MyRendom).Invoke();

            }
            double count = 0;
            //создаем экземпляр класса-делегата AllArray и сообщаем с ним анонимный метод
            AllArray allArray = delegate(DelRendom[] delRendoms)
            {

                foreach (var t in delRendoms)
                {
                    count+= t.Invoke();
                  
                }

               count =count/ 3;
                return count/3;
            };
            //выводим значения лямбда-выражения сообщенного с делегатом
            for (int i = 0; i < arrays.Length; i++)
            {
                Console.Write(arrays[i].Invoke() + " "); //Вызов лямбда-выражения сообщенного с делегатом
            }


            allArray(arrays);
            Console.WriteLine("\n"+count);
          

            Console.ReadKey();
        }
    }
}

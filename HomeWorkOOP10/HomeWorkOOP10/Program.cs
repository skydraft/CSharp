using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP10
{
    /* Задание 
     * Создайте класс MyClass<T>, содержащий статический фабричный метод – T FacrotyMethod(),
     * который будет порождать экземпляры типа,
     * указанного в качестве параметра типа (указателя места заполнения типом – Т). 
     */
    class  MyClass<T> where T : new()
    {

        public static T FacrotyMethod()
        {
            return new T();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> myint= new MyClass<int>();
            Console.WriteLine(myint.GetType());
            Console.ReadKey();
           
        }
    }
}

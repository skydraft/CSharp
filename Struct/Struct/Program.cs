using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    /*
    Создайте структуру MathStruct, вложенную в класс MyClass, и напишите для нее метод Square, который будет принимать значение число типа int и возвращать его квадрат.
    */
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.MathStruct instance = new MyClass.MathStruct();
            int square = instance.Square(7);
            Console.WriteLine(square);

            Console.ReadKey();
        }
    }

    
    class MyClass
    {
        //nested(вложенная) структура MathStruct в класс MyClass
        public struct MathStruct
        {
           
            public int Square(int i)
            {
                return i * i;
            }
        }
    }
}

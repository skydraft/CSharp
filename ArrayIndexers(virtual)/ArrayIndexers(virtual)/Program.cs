using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
В классе Base создайте виртуальный индексатор с одним методом свойства get, который просто будет возвращать arr[i],
а в классе Derived его переопределите таким образом,
чтобы он возвращал сумму i-того элемента массива базового класса и i-того элемента массива производного.
*/

namespace ArrayIndexers_virtual_
{
    class Program
    {
        static void Main(string[] args)
        {
            //реализация виртуального индексатора из класса Base и Derived
            Base inst1 = new Base();
            Console.WriteLine(inst1[3]);
            Base inst2 = new Derived();
            Console.WriteLine(inst2[2]);
            Console.WriteLine(new String('-',30));
            //реализация двумерного индексатора из класса DoubleIndexer
            DoubleIndexer doubleIndexer = new DoubleIndexer();
            Console.WriteLine(doubleIndexer[6, " six"]);
            Console.WriteLine(doubleIndexer[4, " fourth item"]);

            Console.WriteLine(new String('-', 30));
            //реализация индексатора с проверкой выхода индекса за диапазон массива из класса ProtectedIndexer
            ProtectedIndexer protectedIndexer = new ProtectedIndexer();

            Console.WriteLine(protectedIndexer[2]);
            //выход за пределы массива
            Console.WriteLine(protectedIndexer[10]);
            protectedIndexer[10] = "ten";

            Console.ReadKey();
        }
    }

    class Base
    {
        private int[] arr = new int[] { 1, 2, 3, 4, 5 };
        //получаем значение i-го элемента
        public virtual int this[int i] { get { return arr[i]; } }
    }

    class Derived : Base
    {
        private int[] arr = new int[] { 6, 7, 8, 9, 10 };
        //получаем значение суммы i-го элемента базового класса и i-го элемента из класса наследника 
        public override int this[int i]
        {
            get
            {

                return base[i] + arr[i];

            }
        }
    }
}

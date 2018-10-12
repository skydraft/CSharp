using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP9_1
{

    /*Задание
     * Создайте четыре лямбда оператора для выполнения арифметических действий:
     * (Add – сложение, Sub – вычитание, Mul – умножение, Div – деление).
     * Каждый лямбда оператор должен принимать два аргумента и возвращать результат вычисления.
     * Лямбда оператор деления должен делать проверку деления на ноль.
     * Написать программу, которая будет выполнять арифметические действия указанные пользователем.
     */
     //структура описывает первое, второе число и знак операции
    struct MyStructConsol
    {
        public static string first;
        public static string secont;
        public static string operat;


    }
    
    delegate int Calc(int a,int b);
    class Calcs
    {
        
        void MyCalc()
        {
            Calc calc = null;
                   
            int a1 = Convert.ToInt32(MyStructConsol.first);
            int b1= Convert.ToInt32(MyStructConsol.secont);
            //В соответствии с указанным знаком, производится математическая операция
            switch (MyStructConsol.operat)
            {
                case "+":
                    calc= (a, b) => { return a + b; };
                    break;
                case "-":
                    calc = (a, b) => { return a - b; };
                    break;

                case "*":
                    calc = (a, b) => { return a * b; };
                    break;
                case "/":
                    calc = (a, b) => { if (b == 0) { Console.WriteLine("деление на ноль недопустимо"); return 0; } else { return a / b; } };
                    break;
                default:
                  
                        Console.WriteLine("Вы ввели недопустимую операцию");
                        
                    break;

            }
            //если делегат указывает на лямбда-оператор, отобразить результат
            if (calc != null)
            { 
            Console.WriteLine(calc(a1, b1));
            }

        }
        //метод для запроса и вывода результата
        public void MyConsole()
        {
           
            Console.WriteLine("Введите первое число");
            MyStructConsol.first = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            MyStructConsol.secont = Console.ReadLine();
            Console.WriteLine("Введите знак операции");
            MyStructConsol.operat = Console.ReadLine();
           
            MyCalc();
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calcs calcs=new Calcs();
            
            calcs.MyConsole();
            
            Console.ReadKey();

        }
    }
}

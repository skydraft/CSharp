using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP7
{
    /*Задание 
     * Создайте структуру с именем - Notebook. 
     * Поля структуры: модель, производитель, цена.
     * В структуре должен быть реализован конструктор для инициализации полей и метод для вывода содержимого полей на экран.
     * 
     *
     */
    class Program
    {
        
        static void Main(string[] args)
        {
            Notebook notebook=new Notebook("sd123","HP",12.0);
            notebook.Show();
            Notebook notebook1 = new Notebook( "HP");
            notebook1.Show();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP7_1
{
    /* Задание 
     * Описать структуру с именем Train, содержащую следующие поля: название пункта назначения, номер поезда, время отправления.
     *Написать программу, выполняющую следующие действия:
     * - ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train (записи должны быть упорядочены по номерам поездов);
     * - вывод на экран информации о поезде, номер которого введен с клавиатуры (если таких поездов нет, вывести соответствующее сообщение). 
     */
    class Program
    {
        static void Main(string[] args)
        {
            //создаем массив для расписания
            Train[] trains = new Train[3];
            //добавляем поезд в расписание
            StaticTrain.AddTrain(trains);
            //поиск поезда по номеру
            StaticTrain.Search(trains,3);

            Console.ReadKey();
        }
    }
}

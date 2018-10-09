using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP7_1
{
    static class StaticTrain
    {

        public static Train[] AddTrain(Train[] trains )
        {
           //создаем экземпляр с параметрами по умолчанию
            var a1 = new Train();
            //счетчик заполнения массива
            int count = 0;
            for (int x = 0; x < trains.Length; x++)
            {

                Console.WriteLine("Введите пункта назначения:");
                string punkt = Console.ReadLine();
                Console.WriteLine("Введите номер поезда:");
                //TODO не реализована проверка ввода numberTrain (совпадения и строка)
                int numberTrain =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите время отправления:");
                string timeTrain = Console.ReadLine();
                //записываем элемент в массив
                for (int i = 0; i < trains.Length; i++)
                {
                       if (trains[i] != a1) { count++; }

                       //проверяем можно ли записать элемент в массив,содержит ли элемент массива пользовательские данные

                       if (trains[i] == a1)
                       {
                           trains[i] = new Train(punkt, numberTrain, timeTrain);

                           break;
                       }
                    

                }
                //проверяем заполнен ли массив
                if (count >= trains.Length)
                {
                    Console.WriteLine("массив заполнен: ");
                    Sort(trains);
                    break;

                }
                Console.WriteLine("Для выхода наберите exit,для продолжения нажмите enter");
                string exit = Console.ReadLine().ToUpper();
                if (exit =="EXIT")
                {
                    Sort(trains);
                    break;
               
                }
                
            }
            return trains;     

        }
        //сортировка массива
        static void Sort(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                for (int j = 0; j < trains.Length; j++)
                {
                    if (trains[i].TrainNumber < trains[j].TrainNumber)
                    {
                        Train t = trains[i];
                        trains[i] = trains[j];
                        trains[j] = t;
                    }
                }
            }
            //выводим упорядоченный по номеру поезда массив на экран
            foreach (Train train in trains) { Console.WriteLine(train.TrainNumber + " " + train.NameTrainTo + " " + train.Date); }
        }
     
        public static void Search(Train[] trains,int numberTrain)
        {
            //индикатор совпадения номера поезда
             bool count = false;

            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].TrainNumber == numberTrain)
                {
                    Console.WriteLine("Поезд найден: {0} {1} {2} ", trains[i].TrainNumber, trains[i].NameTrainTo, trains[i].Date);
                    count=true;
                }
                
            }
            if (count == false)
            {
                Console.WriteLine("поезд с таким номером отсутствует");
            }
        }
    }
}

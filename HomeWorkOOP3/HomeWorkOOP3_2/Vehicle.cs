using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Описание
/*Создать класс Vehicle.
В теле класса создайте поля:  координаты и параметры средств передвижения(цена, скорость, год выпуска).  
Создайте 3 производных класса Plane, Саг и Ship.
Для класса Plane должна быть определена высота и количество пассажиров.
Для класса Ship — количество пассажиров и порт приписки.
Написать программу, которая выводит на экран информацию о каждом средстве передвижения.*/
#endregion
namespace HomeWorkOOP3_2
{
    class Vehicle
    {
        //поле роординаты

        //поле цена
        int price;
        public int Price { get; set; }
        //поле скорость
        public int Speed { get; set; }
        //поле год выпуска
        public string ReleaseYear { get; set; }
       
        public Vehicle(int price,int speed,string releaseYear)
        {
            this.Price = price;
            this.Speed = speed;
            this.ReleaseYear = releaseYear;
        }
        public void Plane()
        {
            Plane plane = new Plane();
            Console.WriteLine(plane.heidg); 
            Console.WriteLine("Plane");

        }


    }
}

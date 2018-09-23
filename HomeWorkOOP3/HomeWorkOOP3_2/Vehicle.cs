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
        public int X { get; set; }
        public int Y{ get; set; }
        public double Price { get; set; }
        public double Speed { get; set; }
        public string ReleaseYear { get; set; }
        private int people;
        public int People { get { return people; } set { people = value; } }
        public Vehicle(int people)
        {
            People = people;
        }


    }
}

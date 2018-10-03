using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP3_2
{
    class Ship:Vehicle
    {
       private string port;
        public string Port
        {
            get
            {
                if (port == null) return "Порт не задан";
                else return port;
            }
            set
            {
                // if (value == null) port = "Порт не задан";
                // else
                port = value;
            }
        }
        private uint people ;
        public  uint People
        {
            get
            {
                 return people;
            }
            set
            {
                if (value < 0) people =0;
                else people = value;
            }
        }
        public Ship(int price,int speed, string releaseYear):base(price,speed,releaseYear)
        {

        }
        
    }
}

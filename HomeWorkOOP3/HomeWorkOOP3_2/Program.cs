using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Ship ship = new Ship(100, 10, "1999") {Port="NSK",People=20};
            Console.Write("price:{0} speed:{1} year:{2} port:{3} people:{4}",ship.Price,ship.Speed,ship.ReleaseYear,ship.Port,ship.People);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress();
            adress.Apartment = 26;
            adress.Country = "fool";
            adress.House = 25;
            adress.Index = "648382";
            adress.Street = "Dachnaya";
            Console.WriteLine(adress.Index);
            Console.WriteLine(adress.Country);
            Console.WriteLine(adress.Street);
            Console.WriteLine(adress.House);
            Console.WriteLine(adress.Apartment);
            Console.ReadKey();
        }
    }
}

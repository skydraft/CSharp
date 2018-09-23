using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int factr = 1;
            int summ=1;
            do
            {
                summ = summ * factr;
                factr++;

            }
            while (factr <= 7);
            Console.WriteLine("Факториал {0} = {1}",factr-1,summ);
            Console.ReadKey();
            }
    }
}

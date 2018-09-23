using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=1,y=12,z=1;
            int s;
            Console.WriteLine(12>>2);
            x = y >> x++ * z;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}

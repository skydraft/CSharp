using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP3
{
    class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
        public virtual void Method()
        {
            Console.WriteLine("Method from BaseClass");
        }


        /*  public void Show(string color)
          {
              Print(color);
          }*/
    }
}

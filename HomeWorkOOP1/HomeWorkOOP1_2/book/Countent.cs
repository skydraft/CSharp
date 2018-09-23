using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP1_2
{
    class Countent
    {
        private string nameCountent;
        public string NameCountent {
            get { return nameCountent; }
            set { nameCountent = value; }


        }
        public void Show()
        {
            Console.WriteLine(nameCountent);
        }
    }
}

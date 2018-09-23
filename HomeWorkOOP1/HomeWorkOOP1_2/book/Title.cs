using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP1_2
{
    class Title
    {
        private string nameTitle;
        public string NameTile
        {
            get
            {
                return nameTitle;
            }
            set
            {
                nameTitle = value;
            }
        }
        public void Show()
        {
            Console.WriteLine(nameTitle);
        }
    }
}

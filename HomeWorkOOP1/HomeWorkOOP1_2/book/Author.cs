using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP1_2
{
    class Author
    {
        private string nameAuthor;
        public string NameAuthor
        {
            get { return nameAuthor; }
            set { nameAuthor = value; }
        }
       public void Show()
        {
            Console.WriteLine(nameAuthor);
        }
    }
}


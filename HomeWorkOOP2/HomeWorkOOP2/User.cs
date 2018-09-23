using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP2
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Famil { get; set; }
        public string Age { get; set; }
        //readonly- можно поменять только в конструкторе
        private readonly string dateAnket;
        public User(string dateTimeAnket)
        {
            dateAnket = dateTimeAnket;
        }
        public void Show()
        {
            Console.WriteLine("Login={0}",Login);
            Console.WriteLine("Nmae={0}", Name);
            Console.WriteLine("Famil={0}", Famil);
            Console.WriteLine("Age={0}", Age);
            Console.WriteLine("Date Ankety={0}", dateAnket);
        }
    }
}

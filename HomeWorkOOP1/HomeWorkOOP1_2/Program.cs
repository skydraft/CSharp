using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Title("бла бла бла");
            book.Countent("что то есть");
            book.Author("автор был");
            book.NameBook = "Моя книга";
            book.Show();
            Console.ReadKey();
        }
    }
}

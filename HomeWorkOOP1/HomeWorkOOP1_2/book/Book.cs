using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP1_2
{
    class Book
    {
        private string nameBook;
        Title title;
        Author author;
        Countent countent;
        public string NameBook
        {
            get { return nameBook; }
            set { nameBook = value; }
        }
        void Inicialisation()
        {
            this.countent = new Countent();
            this.title = new Title();
            this.author = new Author();
        }

        public Book()
        {
            
            Inicialisation();
        }
        
        public void Title(string title)
        {
            this.title.NameTile = title;
        }
        public void Author(string author)
        {
            this.author.NameAuthor = author;
        }
        public void Countent(string countent)
        {
            this.countent.NameCountent = countent;
        }
        public void Show()
        {
            Console.WriteLine(this.nameBook);
            this.title.Show();
            this.author.Show();
            this.countent.Show();
        }

    }
}

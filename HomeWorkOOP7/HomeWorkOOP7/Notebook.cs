using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP7
{
    struct Notebook
    {
        string model;
        string vendor;
        double price;
        public Notebook(string model, string vendor, double price)
        {
            this.model = model;
            this.vendor = vendor;
            this.price = price;
        }
        //перегрузка пользовательского конструктора принемает 1 аргумент
        public Notebook(string vendor):this("",vendor,0.0)
        {
            
        }
        //Метод отображения

        public void Show()
        {
            Console.WriteLine("модель {0}, производитель {1}, цена {2}",model,vendor,price);
        }
    }
}

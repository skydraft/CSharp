using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP5
{
    class Store
    {
        private Article[] articles;
 
        //maxTovar опряделяет сколько товаров у нас будет
        public Store(int maxTovar)
        {
            articles=new Article [maxTovar];
        }
        //добовляем товара в массив с указанием индекса
        public void AddTovar(Article article,int index)
        {
            articles[index] = article;

        }
        //вывод информации о товаре по номеру с помощью индекса
        public string this[int index]
        {
            get
            {
               if((index<0)|(index>= articles.Length))
                { return string.Format("товар с номером {0} отсутствует", index); }
                return articles[index].Show();
            }
           

        }
        //вывод на экран информации о товаре, по его названию
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].TovarName == index)
                    {
                        return articles[i].Show();
                    }
                }
                return index+" "+"такой товар отсутствует";
            }


        }
       //вывести все элементы массива
       public void ShowAll()
        {
            for (int i = 0; i < articles.Length; i++)
            {
                Console.WriteLine(articles[i].Show());
            }
        }

        public void Sort()
        {
           
            for (int i = 0; i < articles.Length; i++)
            {
                for (int j = 0; j < articles.Length; j++)
                {
                    if (articles[i].Price < articles[j].Price)
                    {
                        Article t = articles[i];
                        articles[i] = articles[j];
                        articles[j] = t;
                    }
                }
            }
                   }
    }
}

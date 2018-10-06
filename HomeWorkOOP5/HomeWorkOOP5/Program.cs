using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP5
{
/*    Задание 4 
  
  Создать класс Article, содержащий следующие закрытые поля: 
  • название товара; 
  • название магазина, в котором продается товар; 
  • стоимость товара .
  Создать класс Store, содержащий закрытый массив элементов типа Article.  
  Обеспечить следующие возможности: 
  • вывод информации о товаре по номеру с помощью индекса; 
  • вывод на экран информации о товаре, по его названию, если таких товаров нет, выдать соответствующее сообщение; 
  • отсортировать товвары по цене;
    Написать программу, вывода на экран информацию о товаре.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(5);
                  
            //добовляем товары в массив
            store.AddTovar(new Article("Book", "MackMilan", 22.50),0);
            store.AddTovar(new Article("Book1", "MackMilan1", 19.50), 1);
            store.AddTovar(new Article("Book2", "MackMilan2", 20.50), 2);
            store.AddTovar(new Article("Book1", "MackMilan1", 21.50), 3);
            store.AddTovar(new Article("Book2", "MackMilan2", 22.50), 4);
            //вывод на экран информации о товаре, по его названию
            Console.WriteLine(store["Book1"]);
            //вывод информации о товаре по номеру с помощью индекса
            Console.WriteLine(store[-1]);
            //вывода на экран информацию о всех товарх
            store.ShowAll();
            //сортировка товара по цене
            store.Sort();
            store.ShowAll();
           
            Console.ReadKey();

        }
    }
}

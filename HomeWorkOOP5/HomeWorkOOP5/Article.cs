using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP5
{
    class Article
    {
        //название товара
        private string tovarName;
        //название магазина в котором есть товар
        private string shopName;
        //цена товара
        private double price;
        
        public string TovarName { get { return tovarName; } set { tovarName = value; } }
        public string ShopName { get { return shopName; } set { shopName = value; } }
        public double Price { get { return price; } set { price = value; } }

        public Article(string tovarName,string shopName,double price)
        {
            TovarName = tovarName;
            ShopName = shopName;
            Price = price;
            
        }
        //возвращает строку с товаром
        public string Show()
        {
            return string.Format(TovarName + " " + ShopName + " " + Price);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP4
{
    class Document
    {
        AbstractHandler handler = null;
        //указатель верный формат или нет
        int a = 0;
        //определяем какой формат и в соответствии с форматом создаем экземпляр класса
        public void ChooseDocument(string fileName)
        {
            //subFileName содержит последнии 4 символа из строки
            string subFileName = fileName.Substring(fileName.Length - 4);
            switch (subFileName)
            {
                case ".doc":handler = new DOCHandler();
                    a = 0;
                    break;
                case ".txt":
                    a = 0;
                    handler = new TXTHandler();
                    break;
                case ".xml":
                    handler = new XMLHandler();
                    a = 0;
                    break;
                default: Console.WriteLine("Неверный формат");
                    a=1;
                   
                    break;
                    
            }
        }
        public void Open()
        {
            if ((handler != null) & (a==0))
            {
                handler.Open();
            }
        }
        public void Create()
        {
            if ((handler != null) & (a == 0))
            {
                handler.Create();
            }
        }
        public void Chenge()
        {
            if (handler != null)
            {
                handler.Chenge();
            }
        }
        public void Save()
        {
            if (handler != null)
            {
                handler.Save();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP3_3
{
    /*Задание 4 
     * Создайте класс DocumentWorker.
     * В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
     * В тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт", 
     * "Редактирование документа доступно в версии Про", "Сохранение документа доступно в версии Про".   
     * Создайте производный класс ProDocumentWorker.
     * Переопределите соответствующие методы, при переопределении методов выводите следующие строки:
     * "Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт".
     * Создайте производный  класс ExpertDocumentWorker от базового класса ProDocumentWorker.
     * Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран "Документ сохранен в новом формате". 
     * В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp.
     *  Если пользователь не вводит ключ, он может пользоваться только бесплатной версией
     * (создается экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp, 
     *  то должен создаться экземпляр соответствующей версии класса, приведенный к базовому – DocumentWorker.
    */





    class Program
    {
        static void Main(string[] args)
        {
            //Создание переменную типа DocumentWorker и зануляем
            DocumentWorker documentWorker = null;
            Console.WriteLine("Введите ключ продукта(pro или exp)");
            string key = Console.ReadLine();
            //проверяем какой ключ ввел пользователь 
            switch (key)
            {
                case "pro":
                    //создаем экземпляр класса и приводим к базовому типу
                    documentWorker = new ProDocumentWorker();
                    Console.WriteLine("ProDocumentWorker");
                    break;
                case "exp":
                    documentWorker = new ExpertDocumentWorker();
                    Console.WriteLine("ExpertDocumentWorker");
                    break;
                default: documentWorker = new DocumentWorker();
                    Console.WriteLine("DocumentWorker");
                    break;
            }
            ////вызов метода OpenDocument на экземпляре documentWorker класса 
            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();
            Console.ReadKey();
        }
    }
}

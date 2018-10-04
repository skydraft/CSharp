using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP4
{
    /*Задание :
     * Создайте класс AbstractHandler. 
     * В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). 
     * Создать производные классы XMLHandler, TXTHandler, DOCHandler
     * от базового класса AbstractHandler.
     * Написать программу, которая будет выполнять определение документа и для каждого формата должны 
     * быть методы открытия, создания, редактирования, сохранения определенного формата документа. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            Console.WriteLine(new string('-', 30));
            document.ChooseDocument("blablabla123.xm");
            document.Create();
            Console.WriteLine(new string('-', 30));
            document.ChooseDocument("blablabla.doc");
            document.Create();
            document.Open();
            document.Chenge();
            document.Save();
            Console.WriteLine(new string('-', 30));
            document.ChooseDocument("blablabla123.xml");
            document.Chenge();
            document.Save();
            Console.WriteLine(new string('-', 30));
            document.ChooseDocument("blablabla123.xm");
            Console.WriteLine(new string('-', 30));
            document.ChooseDocument("blablabla123.txt");
            document.Create();
            document.Chenge();
            
            Console.ReadKey();

        }
    }
}

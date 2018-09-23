using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            String login = "Admin";
            String pass = "P@ssw0rd";
            Console.Write("Введите логин: ");
            string loginInput = Console.ReadLine();
            if ( login== loginInput)
            {
                Console.Write("Введите пароль: ");
                
                if (pass == Console.ReadLine())
                {
                    Console.WriteLine("Вы вошли в систему под ползователем {0}", login);
                }
                else
                {
                    Console.WriteLine("Неверный пароль");
                }

            }
            else
            {
                Console.WriteLine("Неверный логин");
            }
            Console.ReadKey();
        }
    }
}

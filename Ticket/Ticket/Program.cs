using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket
{
     class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите шести значный номенр билета: ");
                string ticket = Console.ReadLine();
                MyClass myClass = new MyClass();

                bool yes = myClass.IsLuckyTicket(ticket);
                if (yes) { Console.WriteLine("Билет счатливый"); }
                else { Console.WriteLine(yes); }



                Console.ReadKey();
            }

        }
        class MyClass
        {

            public bool IsLuckyTicket(string ticket)
            {

                try
                {
                    int numberTicketA = 0;
                    int summA = 0;
                    int summB = 0;
                    string b = "";
                    //проверяем длинну строки
                    if (ticket.Length != 6)
                    {
                        throw new ArgumentException();
                    }
                    //проверяем является ли сторока числом
                    bool numberTicket = Int32.TryParse(ticket, out int result);
                    if (!numberTicket)
                    {
                        return numberTicket;
                    }
                    
                    //формируем стороки из первых трех символов  и последних трех символов
                    string ticket1 = ticket.Substring(0, 3);
                    string ticket2 = ticket.Substring(3);
                    //сумма чисел в строке  
                    foreach (char a in ticket1)
                    {

                        b = a.ToString();
                        numberTicketA = Convert.ToInt32(b);
                        summA = summA + numberTicketA;
                    }
                    foreach (char a in ticket2)
                    {

                        b = a.ToString();
                        numberTicketA = Convert.ToInt32(b);
                        summB = summB + numberTicketA;
                    }
                    if (summA == summB) { return true; }
                    return false;

                }
                catch
                {
                    return false;

                }

            }

        }
    
}

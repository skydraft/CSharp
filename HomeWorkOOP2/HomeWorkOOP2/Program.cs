using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("21.10.2018")
            {
                Age = "25",
                Famil = "Petrov",
                Login = "petroff",
                Name = "Ivan"
                
            };
            
            user.Show();
            Console.ReadKey();
        }
    }
}

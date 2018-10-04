using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP4
{
    class DOCHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("open DOCHandler");
        }
        public override void Chenge()
        {
            Console.WriteLine("chenge DOCHandler");
        }
        public override void Save()
        {
            Console.WriteLine("save DOCHandler");
        }
        public override void Create()
        {
            Console.WriteLine("create DOCHandler");
        }
    }
}

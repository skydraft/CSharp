using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP4
{
    class TXTHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("open TXTHandler");
        }
        public override void Chenge()
        {
            Console.WriteLine("chenge TXTHandler");
        }
        public override void Save()
        {
            Console.WriteLine("save TXTHandler");
        }
        public override void Create()
        {
            Console.WriteLine("create TXTHandler");
        }
    }
}

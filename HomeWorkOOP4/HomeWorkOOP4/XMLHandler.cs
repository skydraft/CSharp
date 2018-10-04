using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP4
{
    class XMLHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("open XMLHandler");
        }
        public override void Chenge()
        {
            Console.WriteLine("chenge XMLHandler");
        }
        public override void Save()
        {
            Console.WriteLine("save XMLHandler");
        }
        public override void Create()
        {
            Console.WriteLine("create XMLHandler");
        }
    }
}

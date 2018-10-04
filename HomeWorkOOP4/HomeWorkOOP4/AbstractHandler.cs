using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP4
{
    abstract class AbstractHandler
    {
        string fileName;
        public string FileName { get; set; }
        public abstract void Open();
        public abstract void Create();
        public abstract void Chenge();
        public abstract void Save();

    }
}

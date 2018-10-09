using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP7_1
{
    struct Train
    {
       public string NameTrainTo;
        public int TrainNumber;
        public string Date;
        
        public Train(string NameTrainTo, int TrainNumber, string Date) 
        {
           this.NameTrainTo= NameTrainTo;
            this.TrainNumber= TrainNumber;
            this.Date= Date;

    }
        //перегрузка операторов == и != для сравнения структурного типа
        public static bool operator ==(Train op1, Train op2)
        {
            return op1.Equals(op2);
        }
        //
        public static bool operator !=(Train op1, Train op2)
        {
            return !op1.Equals(op2);
        }

    }
}

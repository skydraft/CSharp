using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP1
{
    class Adress
    {
        string index;
        string country;
        string street;
        int house;
        int apartment;
        //автоматичнски реализуемые свойства
        //
       public string Index { get; set; }
       public string Country {
            get {
                return country;
            }
            set {if (value != "fool") country = value;
                else { country = "Not country"; }
            } }
       public string Street { get; set; }
        public int House { get; set; }
        public int Apartment { get; set; }
        
    }
}

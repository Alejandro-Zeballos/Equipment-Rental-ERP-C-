using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools_Renting_System_Information.model.pocos
{
    public class Sucursal
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int monthlyRent { get; set; }

        public Sucursal(string name, string address, int rent)
        {
            this.name = name;
            this.address = address;
            this.monthlyRent = monthlyRent;
        }


    }
}

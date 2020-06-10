using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools_Renting_System_Information.model
{
    public class Sales
    {
        public int id { get; set; }
        public Equipo equipo { get; set; }
        public Customer customer { get; set; }
        public int quantity { get; set; }
        public int importe { get; set; }
        public string date { get; set; }

        public Sales(Equipo equipo, Customer customer, int quantity, int importe, string date)
        {
            this.equipo = equipo;
            this.customer = customer;
            this.quantity = quantity;
            this.importe = importe;
            this.date = date;
        }
    }
}

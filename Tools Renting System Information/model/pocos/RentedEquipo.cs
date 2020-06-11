using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools_Renting_System_Information.model
{
    public class RentedEquipo
    {
        [Browsable(false)] public int id { get; set; }
        public int idEquipo { get; set;}
        [Browsable(false)] public int idCustomer { get; set; }
        [Browsable(false)] public int idUser { get; set; }
        public int quantity { get; set; }
        public int importe { get; set; }
        public string dateRented { get; set; }
        public string dateReturn { get; set; }
        [Browsable(false)] public bool isReturned { get; set; }

        public RentedEquipo(int idEquipo, int idCustomer, int idUser,
                            int quantity, int importe,
                            string dateReturn, string dateRented, bool isReturned)
        {
            this.idEquipo = idEquipo;
            this.idUser = idUser;
            this.idCustomer = idCustomer;
            this.quantity = quantity;
            this.importe = importe;
            this.dateRented = dateRented;
            this.dateReturn = dateReturn;
            this.isReturned = isReturned;
        }
    }
}

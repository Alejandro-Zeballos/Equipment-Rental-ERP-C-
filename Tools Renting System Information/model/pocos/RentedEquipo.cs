using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools_Renting_System_Information.model
{
    public class RentedEquipo
    {
        public int id { get; set; }
        public int idEquipo { get; set;}
        public int idCustomer { get; set; }
        public int idUser { get; set; }
        public int quantity { get; set; }
        public int importe { get; set; }
        public string dateRented { get; set; }
        public string dateReturn { get; set; }
        public bool isReturned { get; set; }

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

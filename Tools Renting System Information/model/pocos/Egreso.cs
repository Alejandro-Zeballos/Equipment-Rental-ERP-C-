using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model.enums;

namespace Tools_Renting_System_Information.model.pocos
{
    class Egreso
    {
        public int id { get; set; }
        public Egresos egresos { get; set; }
        public Enum subEgresos { get; set; }
        public int idUser { get; set; }
        public string recibo { get; set; }
        public string date { get; set; }
        public int idBranch { get; set; }
        public string description { get; set; }
        public int monto { get; set; }

        public Egreso(Egresos egreso, Enum subEgresos, string recibo, string date, int idUser, int idBranch, string description, int monto)
        {
            this.egresos = egreso;
            this.subEgresos = subEgresos;
            this.recibo = recibo;
            this.description = description;
            this.monto = monto;
            this.idUser = idUser;
            this.idBranch = idBranch;
            this.date = date;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model.enums;

namespace Tools_Renting_System_Information.model
{
    public class Equipo
    {
        public int id { get; set; }
        [Browsable(false)] public int idBranch { get; set; }
        [Browsable(false)] public eTypeEquipo type { get; set; }
        public string model { get; set; }
        [Browsable(false)] public string dateBought { get; set; }
        public string description { get; set; }
        public int priceItem { get; set; }
        public int hourlyPrice { get; set; }
        public bool isAvailable { get; set; }

        public Equipo(int idBranch, string model, eTypeEquipo type, string dateBought, string description, int priceItem, int hourlyPrice)
        {
            this.model = model;
            this.type = type;
            this.dateBought = dateBought;
            this.description = description;
            this.priceItem = priceItem;
            this.hourlyPrice = hourlyPrice;
            this.idBranch = idBranch;
            isAvailable = true;
        }
    }
}

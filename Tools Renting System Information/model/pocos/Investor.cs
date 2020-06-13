using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools_Renting_System_Information.model.pocos
{
    public class Investor
    {
        public int id { get; set; }
        public string name { get; set; }
        public int totalInvest { get; set; }
        public int totalRetiros { get; set; }
        public string memberSince { get; set; }

        public Investor(string name, int totalInvest, int totalRetiros, string memberSince)
        {
            this.name = name;
            this.totalInvest = totalInvest;
            this.totalRetiros = totalRetiros;
            this.memberSince = memberSince;
        }

        public override string ToString()
        {
            return name;
        }
    }
}

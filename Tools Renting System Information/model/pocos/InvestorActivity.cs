using Syncfusion.Windows.Forms.Tools.MultiColumnTreeView;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model.enums;

namespace Tools_Renting_System_Information.model.pocos
{
    public class InvestorActivity
    {
        public int id { get; set; }
        public int idInvestor { get; set; }
        public Activity activity { get; set; }
        public int amount { get; set; }
        public string date { get; set; }
        public string description { get; set; }

        public InvestorActivity(int idInvestor, Activity activity, int amount, string date, string description)
        {
            this.idInvestor = idInvestor;
            this.activity = activity;
            this.amount = amount;
            this.date = date;
            this.description = description; 
        }
    }
}

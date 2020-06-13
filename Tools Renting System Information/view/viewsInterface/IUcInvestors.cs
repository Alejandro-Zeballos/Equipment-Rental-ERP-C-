using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model.pocos;

namespace Tools_Renting_System_Information.view.viewsInterface
{
    interface IUcInvestors
    {
        void displayMessage(string message);
        void populateDataGrid(List<InvestorActivity> activities);
        void populateFields(Investor investor);
        void populateComboBox(List<Investor> investorList);
        void clearTextFields();
    }
}

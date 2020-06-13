using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model.pocos;

namespace Tools_Renting_System_Information.model.database.DAOInterfaces
{
    interface InvestorDAO
    {
        Investor getInvestor(int InvestorId);
        List<Investor> getInvestorList();
        bool saveInvestor(Investor investor);
        bool deleteInvestor(Investor investor);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model.pocos;

namespace Tools_Renting_System_Information.model.database.DAOInterfaces
{
    interface InvestorActivityDAO
    {
        List<InvestorActivity> getActivityList();
        List<InvestorActivity> getActivityList(int idInvestor);
        bool saveActivity(InvestorActivity activity);
        InvestorActivity getActivity(int activityId);
    }
}

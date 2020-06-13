using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model.database.DAOInterfaces;
using Tools_Renting_System_Information.model.database.DAOs;
using Tools_Renting_System_Information.model.enums;
using Tools_Renting_System_Information.model.pocos;
using Tools_Renting_System_Information.view.viewsInterface;

namespace Tools_Renting_System_Information.presenter
{
    
    class InvestorsPresenter
    {
        IUcInvestors form;
        public InvestorsPresenter(IUcInvestors form)
        {
            this.form = form;
        }

        public void getInvestorFields(Investor investor)
        {
            List<InvestorActivity> activityList = null;
            InvestorActivityDAO activityDao = new MySqlInvestorActivityDao();
            activityList = activityDao.getActivityList(investor.id);
            if (activityList != null)
            {
                form.populateDataGrid(activityList);
                form.populateFields(investor);
            }
            else form.displayMessage("I could not load list");

        }

        public void getInvestorList()
        {
            List<Investor> investorList = null;
            InvestorDAO investorDao = new MySqlInvestorDAO();
            investorList = investorDao.getInvestorList();
            if (investorList != null)
                form.populateComboBox(investorList);
            else
                form.displayMessage("I could not load investor list");

        }

        public void saveActivity(InvestorActivity activity)
        {
            InvestorActivityDAO activityDao = new MySqlInvestorActivityDao();
            bool success = activityDao.saveActivity(activity);

            if (success)
            {
                form.displayMessage("Activity saved successfully");
                form.clearTextFields();
            }
            else
            {
                form.displayMessage("Something went wrong, try again later");
            }

        }
    }
}

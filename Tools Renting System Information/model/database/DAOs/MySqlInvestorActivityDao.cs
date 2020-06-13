using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model.database.DAOInterfaces;
using Tools_Renting_System_Information.model.enums;
using Tools_Renting_System_Information.model.pocos;

namespace Tools_Renting_System_Information.model.database.DAOs
{
    class MySqlInvestorActivityDao : InvestorActivityDAO
    {
        public InvestorActivity getActivity(int activityId)
        {
            InvestorActivity activity = null;
            DataSource dataSource = DataSource.instance;
            string query = "SELECT * FROM investors_activity " +
                            $"WHERE id = '{activityId}';";
            MySqlDataReader data = dataSource.select(query);

            if (data.Read())
                activity = getActivity(data);

            if (data != null)
                data.Close();

            return activity;
        }

        public List<InvestorActivity> getActivityList()
        {
            DataSource dataSource = DataSource.instance;
            List<InvestorActivity> activityList = new List<InvestorActivity>();

            string query = "SELECT * FROM investors_activity";
            MySqlDataReader data = dataSource.select(query);

            while (data.Read())
                activityList.Add(getActivity(data));

            if (data != null)
                data.Close();

            return activityList;
        }

        public List<InvestorActivity> getActivityList(int idInvestor)
        {
            DataSource dataSource = DataSource.instance;
            List<InvestorActivity> activityList = new List<InvestorActivity>();

            string query = "SELECT * FROM investors_activity " +
                $"WHERE id_investor = '{idInvestor}';";
            MySqlDataReader data = dataSource.select(query);

            while (data.Read())
                activityList.Add(getActivity(data));

            if (data != null)
                data.Close();

            return activityList;
        }

        public bool saveActivity(InvestorActivity activity)
        {
            DataSource dataSource = DataSource.instance;
            string query = "INSERT INTO investors_activity(id_investor,type_activity, amount, date, description) " +
                            $"VALUES('{activity.idInvestor}','{activity.activity}'," +
                            $"'{activity.amount}','{activity.date}','{activity.description}');";

            bool success = dataSource.save(query);

            return success;
        }

        private InvestorActivity getActivity(MySqlDataReader data)
        {
            int id = (int)data["id"];
            int idInvestor = (int)data["id_investor"];
            string activityString = (string)data["type_activity"];
            Activity activity = (Activity)Enum.Parse(typeof(Activity), activityString);
            string description = (string)data["description"];
            string date = ((DateTime)data["date"]).ToString("dd/MM/yyyy HH:mm:ss");
            int amount = (int)data["amount"];
            
            InvestorActivity investorActivity = new InvestorActivity(id,activity,amount,date,description);
            investorActivity.id = id;

            return investorActivity;
        }
    }
}

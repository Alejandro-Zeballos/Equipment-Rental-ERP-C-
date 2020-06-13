using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model.database.DAOInterfaces;
using Tools_Renting_System_Information.model.pocos;

namespace Tools_Renting_System_Information.model.database.DAOs
{
    class MySqlInvestorDAO : InvestorDAO
    {
        public bool deleteInvestor(Investor investor)
        {
            throw new NotImplementedException();
        }

        public Investor getInvestor(int InvestorId)
        {
            Investor investor = null;
            DataSource dataSource = DataSource.instance;
            string query = "SELECT * FROM investors " +
                            $"WHERE id_investor = '{InvestorId}';";
            MySqlDataReader data = dataSource.select(query);

            if (data.Read())
                investor = getInvestor(data);

            if (data != null)
                data.Close();

            return investor;

        }

        private Investor getInvestor(MySqlDataReader data)
        {
            string name = (string)data["name_investor"];
            int totalInvest = (int)data["total_invest"];
            int totalRetiros = (int)data["total_retiros"];
            string memberSince = ((DateTime)data["member_since"]).ToString("dd/MM/yyyy HH: mm:ss");
            int id = (int)data["id_investor"];

            Investor investor = new Investor(name, totalInvest, totalRetiros,memberSince);
            investor.id = id;

            return investor;
        }

        public List<Investor> getInvestorList()
        {
            DataSource dataSource = DataSource.instance;
            List<Investor> investorList = new List<Investor>();

            string query = "SELECT * FROM investors";
            MySqlDataReader data = dataSource.select(query);

            while (data.Read())
                investorList.Add(getInvestor(data));

            if (data != null)
                data.Close();

            return investorList;
        }

        public bool saveInvestor(Investor investor)
        {
            DataSource dataSource = DataSource.instance;
            string query = "INSERT INTO investors(name_investor, total_invest, total_retiros, member_since) " +
                $"VALUES('{investor.name}','{investor.totalInvest}'," +
                $"'{investor.totalRetiros}','{investor.memberSince}');";

            bool success = dataSource.save(query);

            if (success)
                Utils.UpdateCustomers();

            return success;
        }
    }
}

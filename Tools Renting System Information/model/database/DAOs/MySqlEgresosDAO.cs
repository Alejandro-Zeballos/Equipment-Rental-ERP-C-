using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model.database.DAOInterfaces;
using Tools_Renting_System_Information.model.enums;
using Tools_Renting_System_Information.model.enums.egresos;
using Tools_Renting_System_Information.model.pocos;

namespace Tools_Renting_System_Information.model.database.DAOs
{
    class MySqlEgresosDAO : EgresosDAO
    {

        public List<Egreso> getEgresos()
        {
            DataSource dataSource = DataSource.instance;
            List<Egreso> egresoList = new List<Egreso>();

            string query = "SELECT * FROM expenses;";

            MySqlDataReader data = dataSource.select(query);
            while (data.Read())
            {
                Egreso egreso = getEgreso(data);
                egresoList.Add(egreso);
            }

            if (data != null)
                data.Close();

            return egresoList;
        }

        public bool saveEgreso(Egreso egreso)
        {
            DataSource dataSource = DataSource.instance;
            string query = "INSERT INTO expenses(egresos, sub_egresos, receipt_number, id_user, id_branch, description, amount, date) " +
                $"VALUES('{egreso.egresos}','{egreso.subEgresos}'," +
                $"'{egreso.recibo}','{egreso.idUser}','{egreso.idBranch}'," +
                $"'{egreso.description}','{egreso.monto}','{egreso.date}');";

            bool success = dataSource.save(query);

            return success;
        }

        private Egreso getEgreso(MySqlDataReader data)
        {
            int id = (int)data["id_expenses"];
            int idBranch = (int)data["id_branch"];
            int idUser = (int)data["id_user"];
            string egresoString = (string)data["egresos"];
            Egresos egresoType = (Egresos)Enum.Parse(typeof(Egresos), egresoString);
            string subEgresoString = (string)data["sub_egresos"];
            Enum subEgresoType = (Enum)Enum.Parse(Utils.getTypeOfEnum(subEgresoString), subEgresoString);
           
            string date = ((DateTime)data["date"]).ToString("dd/MM/yyyy HH:mm:ss");
            string descrip = (string)data["description"];
            string recibo = (string)data["receipt_number"];
            int amount = (int)data["amount"];


            Egreso egreso = new Egreso(egresoType, subEgresoType, recibo, date, idUser, idBranch, descrip, amount); ;
            egreso.id = id;
            
            return egreso;
        }

        
    }
}

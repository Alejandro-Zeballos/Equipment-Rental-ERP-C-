using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model.enums;

namespace Tools_Renting_System_Information.model.database
{
    class MySqlEquipoDAO : EquipoDAO
    {
        public bool createEquipo(Equipo newEquipo)
        {
            DataSource dataSource = DataSource.instance;
            string query = "INSERT INTO items(id_branch,type_item, model_item, date_bought, description_item," +
                            "price_item, hour_price) " +
                            $"VALUES('{newEquipo.idBranch}','{newEquipo.type}','{newEquipo.model}','{newEquipo.dateBought}'," +
                            $"'{newEquipo.description}','{newEquipo.priceItem}','{newEquipo.hourlyPrice}');";

            bool success = dataSource.save(query);

            if (success)
                Utils.UpdateEquipos();

            return success;
        }

        public bool deleteEquipo(Equipo equipo)
        {
            DataSource dataSource = DataSource.instance;
            string query = "DELETE FROM items " +
                $"WHERE id_item = '{equipo.id}';";
            bool success = dataSource.delete(query);

            if (success)
                Utils.UpdateEquipos();

            return success;
        }

        public bool editEquipo(Equipo editedEquipo)
        {
            DataSource dataSource = DataSource.instance;
            string query = "UPDATE items " +
                           $"SET model_item  = '{editedEquipo.model}', description_item = '{editedEquipo.description}'," +
                           $"price_item = '{editedEquipo.priceItem}', hour_price = '{editedEquipo.hourlyPrice}'," +
                           $"is_available = '{editedEquipo.isAvailable}' " +
                           $"WHERE id_item = '{editedEquipo.id}'";
            
            bool success = dataSource.update(query);

            if (success)
                Utils.UpdateEquipos();

            return success;
        }

        public Equipo getEquipo(int idEquipo)
        {
            DataSource dataSource = DataSource.instance;
            Equipo equipo = null;

            string query = "SELECT * FROM items" +
                            $"WHERE id_item = '{idEquipo}';";

            MySqlDataReader data = dataSource.select(query);
            if (data.Read())
                equipo = getEquipo(data);

            if (data != null)
                data.Close();

            return equipo;

        }

        public List<Equipo> getEquiposList()
        {
            DataSource dataSource = DataSource.instance;
            List<Equipo> equipoList = new List<Equipo>();

            string query = "SELECT * FROM items;";

            MySqlDataReader data = dataSource.select(query);
            while (data.Read())
            {
                Equipo equipo = getEquipo(data);
                equipoList.Add(equipo);
            }

            if (data != null)
                data.Close();

            return equipoList;
        }

        private Equipo getEquipo(MySqlDataReader data)
        {
            int id = (int)data["id_item"];
            int idBranch = (int)data["id_branch"];
            string typeString = (string)data["type_item"];
            eTypeEquipo type = (eTypeEquipo)Enum.Parse(typeof(eTypeEquipo), typeString);
            string model = (string)data["model_item"];
            string dateBought = ((DateTime)data["date_bought"]).ToString("dd/MM/yyyy HH:mm:ss");
            string descrip = (string)data["description_item"];
            int price = (int)data["price_item"];
            int hourPrice = (int)data["hour_price"];
            bool isAvailable = (bool)data["is_available"];

            Equipo equipo = new Equipo(idBranch, model, type, dateBought, descrip, price, hourPrice);
            equipo.id = id;
            equipo.isAvailable = isAvailable;
            return equipo;
        }
    }
}

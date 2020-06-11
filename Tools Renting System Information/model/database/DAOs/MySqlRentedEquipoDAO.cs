using MySql.Data.MySqlClient;
using Syncfusion.Windows.Forms.Tools.MultiColumnTreeView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools_Renting_System_Information.model.database
{
    class MySqlRentedEquipoDAO : EquipoRentedDAO
    {
        public RentedEquipo getRentedEquipo(int id)
        {
            RentedEquipo rentedEquipo = null;
            DataSource dataSource = DataSource.instance;

            string query = "SELECT * FROM items_rented " +
                            $"WHERE id_items_rented = '{id}'";

            MySqlDataReader data = dataSource.select(query);
            if (data.Read())
                rentedEquipo = getRentedEquipo(data);

            if (data != null)
                data.Close();

            return rentedEquipo;
        }



        public List<RentedEquipo> getRentedEquipoList()
        {
            List<RentedEquipo> rentedEquipoList = new List<RentedEquipo>();

            DataSource dataSource = DataSource.instance;
            string query = "SELECT * FROM items_rented";

            MySqlDataReader data = dataSource.select(query);

            while (data.Read())
            {
                RentedEquipo rentedEquipo = getRentedEquipo(data);
                rentedEquipoList.Add(rentedEquipo);
            }
            if (data != null)
                data.Close();

            return rentedEquipoList;
        }

        public List<RentedEquipo> getRentedEquipoList(Customer customer)
        {
            List<RentedEquipo> rentedEquipoList = new List<RentedEquipo>();

            DataSource dataSource = DataSource.instance;
            string query = "SELECT * FROM items_rented " +
                            $"WHERE id_customer = '{customer.id}' " +
                            "AND is_returned = '1';";

            MySqlDataReader data = dataSource.select(query);

            while (data.Read())
            {
                RentedEquipo rentedEquipo = getRentedEquipo(data);
                rentedEquipoList.Add(rentedEquipo);
            }
            if (data != null)
                data.Close();

            return rentedEquipoList;
        }

        public List<RentedEquipo> getToReturnList()
        {
            List<RentedEquipo> rentedEquipoList = new List<RentedEquipo>();

            DataSource dataSource = DataSource.instance;
            string query = "SELECT * FROM items_rented WHERE is_returned = '0';";

            MySqlDataReader data = dataSource.select(query);

            while (data.Read())
            {
                RentedEquipo rentedEquipo = getRentedEquipo(data);

                rentedEquipoList.Add(rentedEquipo);
            }


            if (data != null)
                data.Close();

            return rentedEquipoList;

        }

        public List<RentedEquipo> getToReturnList(Customer customer)
        {
            List<RentedEquipo> rentedEquipoList = new List<RentedEquipo>();

            DataSource dataSource = DataSource.instance;
            string query = $"SELECT * FROM items_rented " +
                            $"WHERE id_customer = '{customer.id}' " +
                            $"AND is_returned = '0';";

            MySqlDataReader data = dataSource.select(query);

            while (data.Read())
            {
                RentedEquipo rentedEquipo = getRentedEquipo(data);

                rentedEquipoList.Add(rentedEquipo);
            }


            if (data != null)
                data.Close();

            return rentedEquipoList;
        }

        public bool returnEquipo(int rentedEquipoId)
        {
            DataSource dataSource = DataSource.instance;
            string query = "UPDATE items_rented" +
                           " SET is_returned  = '1' " +
                           $"WHERE id_items_rented = '{rentedEquipoId}'";

            bool success = dataSource.update(query);
            if (success)
                Utils.UpdateEquipos();

            return success;
        }


        public bool saveRentedEquipo(RentedEquipo rentedEquipo)
        {
            DataSource dataSource = DataSource.instance;
            string query = "INSERT INTO items_rented(id_item, id_customer, id_user, quantity, importe_total, date_items_rented, date_item_return) " +
                $"VALUES('{rentedEquipo.idEquipo}','{rentedEquipo.idCustomer}'," +
                $"'{rentedEquipo.idUser}','{rentedEquipo.quantity}'," +
                $"'{rentedEquipo.importe}','{rentedEquipo.dateRented}','{rentedEquipo.dateReturn}');";
                //$"UPDATE items SET is_available = '0' WHERE id_item = '{rentedEquipo.id}';";
            bool success = dataSource.save(query);

            if (success)
                Utils.UpdateEquipos();
                
            return success;
        }

        private RentedEquipo getRentedEquipo(MySqlDataReader data)
        {
            RentedEquipo rentedEquipo;
            int theID = (int)data["id_items_rented"];
            int idEquipo = (int)data["id_item"];
            int idCustomer = (int)data["id_customer"];
            int idUser = (int)data["id_user"];
            int quantity = (int)data["quantity"];
            int importe = (int)data["importe_total"];
            DateTime Rdate = (DateTime)data["date_items_rented"];
            string dateRented = Rdate.ToString("dd/MM/yyyy HH: mm:ss");
            string dateReturn = ((DateTime)data["date_item_return"]).ToString("dd/MM/yyyy HH: mm:ss");
            bool isReturned = (bool)data["is_returned"];
            rentedEquipo = new RentedEquipo(idEquipo, idCustomer, idUser, quantity, importe, dateReturn, dateRented, isReturned);
            rentedEquipo.id = theID;

            return rentedEquipo;
        }
    }


}

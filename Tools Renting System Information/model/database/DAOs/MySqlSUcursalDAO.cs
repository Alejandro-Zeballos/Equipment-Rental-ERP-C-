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
    class MySqlSUcursalDAO : SucursalDAO
    {
        public bool addSucursal(Sucursal sucursal)
        {
            DataSource dataSource = DataSource.instance;
            string query = "INSERT INTO branchs(name_branch, address_branch, montly_rent " +
                          $"VALUES ('{sucursal.name}','{sucursal.address}','{sucursal.monthlyRent}');";
            return dataSource.save(query);
        }

        public bool editSucursal(Sucursal sucursal)
        {
            DataSource dataSource = DataSource.instance;
            string query = "UPDATE branchs SET " +
                $"name_brach = '{sucursal.name}', address_branch = '{sucursal.address}', montly_rent = '{sucursal.monthlyRent}' " +
                $"WHERE id_branch = '{sucursal.id}';";
            return dataSource.update(query);
        }

        public Sucursal getSucursal(int sucursalId)
        {
            Sucursal sucursal = null;
            DataSource dataSource = DataSource.instance;
            string query = "SELECT * FROM branchs " +
                $"WHERE id_branch = '{sucursalId}';";

            MySqlDataReader data = dataSource.select(query);
            if (data.Read())
                sucursal = getSucursal(data);

            if (data != null)
                data.Close();

            return sucursal;
        }

        private Sucursal getSucursal(MySqlDataReader data)
        {
            int id = (int)data["id_branch"];
            string name = (string)data["name_branch"];
            string address = (string)data["address_branch"];
            int rent = (int)data["montly_rent"];

            Sucursal sucursal = new Sucursal(name, address, rent);
            sucursal.id = id;
            return sucursal;
        }

        public List<Sucursal> getSucursalList()
        {
            DataSource dataSource = DataSource.instance;
            List<Sucursal> sucursalList = new List<Sucursal>();
            
            string query = "SELECT * FROM branchs";

            MySqlDataReader data = dataSource.select(query);
            
            while (data.Read())
            {
                sucursalList.Add(getSucursal(data));
            }
            if (data != null)
                data.Close();

            return sucursalList;
        }

        public bool removeSucursal(Sucursal sucursal)
        {
            DataSource dataSource = DataSource.instance;
            string query = "DELETE FROM branchs " +
                $"WHERE id_branch = '{sucursal.id}';";

            return dataSource.delete(query);
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools_Renting_System_Information.model.database
{
    class MySqlCustomerDAO : CustomerDAO
    {
        public bool deleteCustomer(Customer customer)
        {
            DataSource dataSource = DataSource.instance;
            string query = "DELETE FROM customer " +
                            $"WHERE id_customer = '{customer.id}'";

            bool success = dataSource.delete(query);

            if (success)
                Utils.UpdateCustomers();

            return success;
        }

        public bool editCustomer(Customer customerEdited)
        {
            DataSource dataSource = DataSource.instance;
            string query = "UPDATE customer " +
                $"SET name_customer = '{customerEdited.name}', email_customer = '{customerEdited.email}'," +
                $"carnet_customer = '{customerEdited.carnet}', address_customer = '{customerEdited.address}'," +
                $"phone_customer = '{customerEdited.phone}' " +            
                $"WHERE id_customer = '{customerEdited.id}';";

            bool success = dataSource.update(query);

            if (success)
                Utils.UpdateCustomers();

            return success;
        }

        public Customer getCustomer(int id)
        {
            Customer customer = null;
            DataSource dataSource = DataSource.instance;
            string query = "SELECT * FROM customer " +
                            $"WHERE id_customer = '{id}';";
            MySqlDataReader data = dataSource.select(query);

            if (data.Read())
                customer = getCustomer(data);

            if (data != null)
                data.Close();

            return customer;

        }

        public List<Customer> getCustomerList()
        {
            DataSource dataSource = DataSource.instance;
            List<Customer> customerList = new List<Customer>();

            string query = "SELECT * FROM customer";
            MySqlDataReader data = dataSource.select(query);

            while (data.Read())
                customerList.Add(getCustomer(data));

            if (data != null)
                data.Close();

            return customerList;

        }

        private Customer getCustomer(MySqlDataReader data)
        {
            string name = (string)data["name_customer"];
            string email = (string)data["email_customer"];
            string carnet = (string)data["carnet_customer"];
            string address = (string)data["address_customer"];
            string phone = (string)data["phone_customer"];
            int id = (int)data["id_customer"];

            Customer customer = new Customer(name, email, carnet, address, phone);
            customer.id = id;

            return customer;
        }

        public bool saveCustomer(Customer customer)
        {
            DataSource dataSource = DataSource.instance;
            string query = "INSERT INTO customer(name_customer, email_customer, carnet_customer, address_customer, phone_customer) " +
                $"VALUES('{customer.name}','{customer.email}'," +
                $"'{customer.carnet}','{customer.address}','{customer.phone}');";

            bool success = dataSource.save(query);

            if (success)
                Utils.UpdateCustomers();

            return success;
        }
    }
}

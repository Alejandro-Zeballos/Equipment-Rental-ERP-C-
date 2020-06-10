using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tools_Renting_System_Information.model
{
    public sealed class DataSource
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string userName;
        private string password;

        private static readonly Lazy<DataSource> lazy = new Lazy<DataSource>(() => new DataSource());

        public static DataSource instance { get { return lazy.Value; } }
        
        private DataSource() {
            server = Utils.SERVER;
            database = Utils.DATABASE;  
            userName = Utils.USER_NAME;
            password = Utils.PASSWORD;
            string connString = $"SERVER={server};DATABASE={database};UID={userName};PASSWORD={password};";
            connection = new MySqlConnection(connString);

            openConnection();
        }

        public void openConnection()
        {
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
            }
        }

        public bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //the update can be a insert, update or delete, depends on the query
        public bool update(string query)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                return true;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return false;
        }

        public bool save(string query)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return false;
        }

        public bool delete(string query)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return false;
        }

        public MySqlDataReader select(string query)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                return dataReader;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }


    }
}

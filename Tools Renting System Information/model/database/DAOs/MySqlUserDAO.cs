using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model.enums;

namespace Tools_Renting_System_Information.model.database
{
    class MySqlUserDAO : UserDAO
    {
        public bool deleteUser(User user)
        {
            DataSource dataSource = DataSource.instance;
            string query = "DELETE FROM users" +
                            $"WHERE id_user = '{user.id}';";

            return dataSource.delete(query);
        }

        public bool editUser(User editedUser)
        {
            DataSource dataSource = DataSource.instance;
            string query = "UPDATE users " +
                   $"SET name_user = '{editedUser.name}', email_user = '{editedUser.email}'," +
                   $"password_user = '{editedUser.password}', privileges = '{editedUser.access}'," +
                   $"aproved = '{editedUser.aproved}', phone = '{editedUser.phone}' " +         
                   $"WHERE id_user = '{editedUser.id}';";

            return dataSource.update(query);
        }

        public User getUser(int id)
        {
            User user = null;
            DataSource dataSource = DataSource.instance;
            string query = "SELECT * FROM users " +
                            $"WHERE id_user = '{id}';";
            MySqlDataReader data = dataSource.select(query);
            if (data.Read())
                user = getUser(data);

            if (data != null)
                data.Close();

            return user;
        }

        public List<User> getUsersList()
        {
            DataSource dataSource = DataSource.instance;
            List <User> userList = new List<User>();

            string query = "SELECT * FROM users;";

            MySqlDataReader data = dataSource.select(query);
            while (data.Read())
            {

                User user = getUser(data);
                userList.Add(user);
            }
            if (data != null)
                data.Close();
            
            return userList;
        }

        private User getUser(MySqlDataReader data)
        {
            int id = (int)data["id_user"];
            string name = (string)data["name_user"];
            string email = (string)data["email_user"];
            string pass = (string)data["password_user"];
            string phone = (string)data["phone"];
            string accessString = (string)data["privileges"];
            Access access = (Access)Enum.Parse(typeof(Access),accessString);

            User user = new User(name, email, pass, phone, access);
            user.id = id;

            return user;
        }

        public User loginUser(string username, string password)
        {
            User user = null;
            DataSource dataSource = DataSource.instance;
            string query = $"SELECT * FROM users " +
                            $"WHERE email_user = '{username}' AND password_user = '{password}';";

            MySqlDataReader data = dataSource.select(query);

            if (data.Read())
                user = getUser(data);

            if (data != null)
                data.Close();

            return user;
        }

        public bool registerUser(User newUser)
        {
            DataSource dataSource = DataSource.instance;
            string query = $"INSERT INTO users(name_user,email_user,password_user,privileges,phone)" +
                            $"VALUES ('{newUser.name}','{newUser.email}','{newUser.password}','{newUser.access}','{newUser.phone}');";
            return dataSource.save(query);
        }
    }
}

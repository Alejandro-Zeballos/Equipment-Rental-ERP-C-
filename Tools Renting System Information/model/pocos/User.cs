using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model.enums;

namespace Tools_Renting_System_Information.model
{
    public class User
    {
        public User(string name, string email, string password, string phone, Access access)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.access = access;
            this.phone = phone;
            this.aproved = 0;
        }

        public int id { get; set; }
        public int aproved { get; set; }
        public string phone { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Access access { get; set; }

    }
}

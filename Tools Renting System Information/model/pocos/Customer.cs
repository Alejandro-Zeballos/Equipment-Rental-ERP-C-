using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tools_Renting_System_Information.model
{
    public class Customer
    {
        public Customer(string name, string email, string carnet, string address, string phone)
        {
            this.name = name;
            this.email = email;
            this.carnet = carnet;
            this.address = address;
            this.phone = phone;
        }

        //TODO im still working in creating the models

        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string carnet { get; set; }
        public string address { get; set; }
        public string phone { get; set; }

        public override string ToString()
        {
            return $"Name: {name}   Email: {email}  Carnet: {carnet}    Phone: {phone}  Address: {address}";

        }
    }
}

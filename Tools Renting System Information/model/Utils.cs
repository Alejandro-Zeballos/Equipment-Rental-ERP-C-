    using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model.database;
using Tools_Renting_System_Information.model.enums;
using Tools_Renting_System_Information.model.pocos;

namespace Tools_Renting_System_Information.model
{
    public sealed class Utils
    {
        //server utils
        public static readonly string SERVER = "localhost";
        public static readonly string DATABASE = "equipos_alquileres";
        public static readonly string USER_NAME = "root";
        public static readonly string PASSWORD = "";

        public static string getCurrentDateTime()
        {
            //TODO: desarrollar this part
            DateTime d = DateTime.Now;
            string date = d.ToString("yyyy/MM/dd HH:mm:ss");
            Console.WriteLine($"current date: {date}");
            return date;
        }

        public static string getDateTime(DateTime dateToConvert)
        {
            string date = dateToConvert.ToString("yyyy/MM/dd HH:mm:ss");
            return date;
        }

        public static List<Customer> customersGlobal { get; set; }
        public static List<Equipo> equiposGlobal { get; set; }
        public static List<User> usersGlobal { get; set; }
        public static List<Sucursal> SucursalsGlobal { get; set; }
        public static Sucursal thisSucursal { get; set; }  
        public static User getUser(int idUser)
        {
            if (usersGlobal != null)
            {

                foreach(User user in usersGlobal)
                {
                    if (user.id == idUser)
                        return user;
                }

            }

            return null;

        }
        public static Customer getCustomer(int idCustomer)
        {
            if (customersGlobal != null)
            {

                foreach (Customer customer in customersGlobal)
                {
                    if (customer.id == idCustomer)
                        return customer;
                }

            }

            return null;
        }
        public static Equipo getEquipo(int idEquipo)
        {
            if (equiposGlobal != null)
            {
                foreach (Equipo equipo in equiposGlobal)
                    if (equipo.id == idEquipo)
                        return equipo;
            }

            return null;
        }

        public static void UpdateCustomers()
        {
            CustomerDAO customerDAO = new MySqlCustomerDAO();
            customersGlobal = customerDAO.getCustomerList();
        }

        public static void UpdateEquipos()
        {
            EquipoDAO equipoDAO = new MySqlEquipoDAO();
            equiposGlobal = equipoDAO.getEquiposList();
        }

        public static Type getTypeOfEnum(string type)
        {
            switch (type)
            {
                case "CONTADOR":
                case "IMPUESTOS":
                    return typeof(EgresoAdministrativo);
                case "ALQUILER":
                case "LUZ":
                case "INTERNET":
                case "SUELDO":
                    return typeof(enums.egresos.EgresoFijo);
                case "GASOLINA":
                case "TARJETA":
                case "ALMUERZO":
                case "PASAJES":
                case "OTRO":
                    return typeof(enums.egresos.EgresoOperativo);
                default:
                    return typeof(enums.egresos.EgresoOperativo);
            }

        }
        public static Customer currentCustomer { get; set; }
        public static User CurrentUser { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model;
using Tools_Renting_System_Information.model.database;
using Tools_Renting_System_Information.view;

namespace Tools_Renting_System_Information.presenter
{
    class CustomerDetailsPresenter
    {
        IUcCustomerDetails form;
        EquipoRentedDAO equipoRentedDao;
        public CustomerDetailsPresenter(IUcCustomerDetails form)
        {
            this.form = form;
            equipoRentedDao = new MySqlRentedEquipoDAO();
        }

        public void getHistorialAlquileres(Customer customer)
        {
            
            try
            {
                List<RentedEquipo> historialList = equipoRentedDao.getRentedEquipoList(customer);
                form.ListHistorialAlquileres(historialList);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                form.DisplayMessage("Something went wrong at fetching data, \n" +
                    "Try again later");
            }
            
        }

        public void getToReturnList(Customer customer)
        {
            try
            {
                List<RentedEquipo> historialList = equipoRentedDao.getToReturnList(customer);
                form.ListToReturnEquipos(historialList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                form.DisplayMessage("Something went wrong at fetching data, \n" +
                    "Try again later");
            }
        }

        internal void selectCustomer(Customer customer)
        {
            Utils.currentCustomer = customer;
            form.DisplayMessage($"User selected correcly: {customer.name}");
            form.CloseForm();
        }
    }
}

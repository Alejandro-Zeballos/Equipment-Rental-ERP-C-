using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools_Renting_System_Information.model;
using Tools_Renting_System_Information.model.database;
using Tools_Renting_System_Information.model.userControl;
using Tools_Renting_System_Information.view;

namespace Tools_Renting_System_Information.presenter
{
    public class HomePresenter
    {
        IUcHome form;
        EquipoRentedDAO equiposRented;
        

        public HomePresenter(IUcHome iucHome)
        {
            this.form = iucHome;
            this.equiposRented = new MySqlRentedEquipoDAO ();
            
        }

        public void getToReturnList()
        {
            List<RentedEquipo> toReturnList = new List<RentedEquipo>();
            List<UcItemRented> ucItemList = new List<UcItemRented>();
            toReturnList = equiposRented.getToReturnList();

            foreach(RentedEquipo item in toReturnList)
            {


                UcItemRented ucItemRented = new UcItemRented();
                ucItemRented.equipoRentedId = item.id;
                ucItemRented.user = Utils.getUser(item.idUser);
                ucItemRented.equipo = Utils.getEquipo(item.idEquipo);
                ucItemRented.UserName = ucItemRented.user.name;
                ucItemRented.Quantity = item.quantity;
                ucItemRented.ItemName = ucItemRented.equipo.type.ToString();
                ucItemRented.DateToReturn = item.dateReturn;
                ucItemRented.customer = Utils.getCustomer(item.idCustomer);
                ucItemRented.CustomerName = ucItemRented.customer.name;
                ucItemRented.Detalle = ucItemRented.equipo.description;
                ucItemRented.TimeLeftToReturn = "1 dia";//getTimeDifference(item.dateToReturn);
                ucItemList.Add(ucItemRented);
            }
            form.displayToReturnItems(ucItemList);
        }

        internal string getTimeDifference(string dateToReturn)
        {
            //TODO: hacer esta parte papirrin
            throw new NotImplementedException();
        }

        internal void returnEquipo(int rentedEquipoId)
        {
            bool success = equiposRented.returnEquipo(rentedEquipoId);

            if (success)
            {
                form.displayMessage("Item Returned");
                getToReturnList();
            }
            else { 
                form.displayMessage("Something happended Item not Returned");
            }
        }
    }
}

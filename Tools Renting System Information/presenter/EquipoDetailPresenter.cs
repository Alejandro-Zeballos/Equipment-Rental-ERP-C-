using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model;
using Tools_Renting_System_Information.model.database;
using Tools_Renting_System_Information.view.viewsInterface;

namespace Tools_Renting_System_Information.presenter
{
    class EquipoDetailPresenter
    {
        IUcEquipoDetail form;
        public EquipoDetailPresenter(IUcEquipoDetail form)
        {
            this.form = form;

        }

        public void getRentalHistory(Equipo equipo)
        {
            EquipoRentedDAO equipoDao = new MySqlRentedEquipoDAO();
            List<RentedEquipo> rentedList = null;

            rentedList = equipoDao.getRentedEquipoList(equipo);

            if(rentedList != null)
            {
                form.listRentingHistory(rentedList);
            
            }
            else
            {
                form.displayMessage("Something went wrong at loading rental history");
            }
        }
    }
}

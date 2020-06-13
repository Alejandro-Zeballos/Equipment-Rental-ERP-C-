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
    
    class EditEquipoPresenter
    {
        IUcEditarEquipo form;
        public EditEquipoPresenter(IUcEditarEquipo form)
        {
            this.form = form;
        }

        public void EditEquipo(Equipo equipo)
        {
            EquipoDAO equipoDao = new MySqlEquipoDAO();
            bool success = equipoDao.editEquipo(equipo);
            if (success)
            {
                form.displayMessage("Equipo edited successfuly");
                form.close();
            }
            else
            {
                form.displayMessage("Something happended\n" +
                    "Equipo could not be deleted");
            }
        }
    }
}

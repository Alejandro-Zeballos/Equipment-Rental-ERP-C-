using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools_Renting_System_Information.model;
using Tools_Renting_System_Information.model.database;
using Tools_Renting_System_Information.view;

namespace Tools_Renting_System_Information.presenter
{
    class AddEquipoPresenter
    {
        IUcAddEquipo addEquipoForm;
        EquipoDAO equipoDAO;

        public AddEquipoPresenter(IUcAddEquipo form)
        {
            this.addEquipoForm = form;
            this.equipoDAO = new MySqlEquipoDAO();
        }

        public void addEquipo(Equipo equipo)
        {
            bool wasCreated = false;
            wasCreated = equipoDAO.createEquipo(equipo);
            if (wasCreated)
            {
                addEquipoForm.emptyTextBoxes();
                addEquipoForm.displayMessage("Equipo was created Successfuly!");
            }
            else
            {
                addEquipoForm.displayMessage("Equipo could not be created :(");
            }

        }
    }
}

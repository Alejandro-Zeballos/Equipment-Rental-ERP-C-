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
    class EquipoListPresenter
    {
        IUcEquipoList form;
        public EquipoListPresenter(IUcEquipoList form)
        {
            this.form = form;
        }

        public void getEquipoList()
        {
            List<Equipo> equipoList = null;

            equipoList = Utils.equiposGlobal;

            if (equipoList != null)
                form.listEquipos(equipoList);
            else
                form.displayMessage("I Could not connect to the server\n" +
                    "try again later");
        }
    }
}

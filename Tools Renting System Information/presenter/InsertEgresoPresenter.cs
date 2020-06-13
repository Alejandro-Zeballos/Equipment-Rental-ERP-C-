using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model.database.DAOInterfaces;
using Tools_Renting_System_Information.model.database.DAOs;
using Tools_Renting_System_Information.model.enums;
using Tools_Renting_System_Information.model.pocos;
using Tools_Renting_System_Information.view.viewsInterface;

namespace Tools_Renting_System_Information.presenter
{
    class InsertEgresoPresenter
    {
        IUcInsertEgreso form;
        public InsertEgresoPresenter(IUcInsertEgreso form)
        {
            this.form = form;
        }

        public void InsertEgreso(Egreso egreso)
        {
            EgresosDAO egresoDao = new MySqlEgresosDAO();
            bool success = egresoDao.saveEgreso(egreso);
            if (success)
            {
                form.displayMessage("Egreso guardado");
                form.clearTextFields();
            }
            else
            {
                form.displayMessage("Algo ocurrio, intente mas tarde");
            }
        }
    }
}

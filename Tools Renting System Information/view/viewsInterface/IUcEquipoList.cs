using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model;

namespace Tools_Renting_System_Information.view.viewsInterface
{
    interface IUcEquipoList
    {
        void listEquipos(List<Equipo> equipoList);
        void displayMessage(string message);
    }
}

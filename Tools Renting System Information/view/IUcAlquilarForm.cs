using Syncfusion.Windows.Forms.Tools.MultiColumnTreeView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model;

namespace Tools_Renting_System_Information.view
{
    interface IUcAlquilarForm
    {
        void listAvailableEquipos(List<Equipo> equipoList);
        void displayMessage(string message);
        void fillUpCustomerName(string name);
        void fillUpImportes(int unitImporte, int totalImporte);
    }
}

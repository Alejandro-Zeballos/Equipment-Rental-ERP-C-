using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools_Renting_System_Information.model.database
{
    interface EquipoDAO
    {
        bool createEquipo(Equipo newEquipo);
        bool deleteEquipo(Equipo equipo);
        Equipo getEquipo(int idEquipo);
        List<Equipo> getEquiposList();
        bool editEquipo(Equipo editedEquipo);
    }
}

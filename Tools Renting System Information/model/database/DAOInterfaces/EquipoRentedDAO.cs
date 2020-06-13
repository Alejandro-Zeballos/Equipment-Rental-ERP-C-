using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools_Renting_System_Information.model.database
{
    interface EquipoRentedDAO
    {
        bool saveRentedEquipo(RentedEquipo rentedEquipo);
        List<RentedEquipo> getRentedEquipoList();
        RentedEquipo getRentedEquipo(int id);
        List<RentedEquipo> getToReturnList();
        bool returnEquipo(int rentedEquipoId);
        List<RentedEquipo> getToReturnList(Customer customer);
        List<RentedEquipo> getRentedEquipoList(Customer customer);
        List<RentedEquipo> getRentedEquipoList(Equipo equipo);
    }
}

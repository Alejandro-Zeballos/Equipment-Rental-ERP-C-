using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model;
using Tools_Renting_System_Information.view.userControl;

namespace Tools_Renting_System_Information.view
{
    public interface IUcAlquilarEquipo
    {
        void displayEquiposItem(List<UcItemEquipo> itemsList);
    }
}

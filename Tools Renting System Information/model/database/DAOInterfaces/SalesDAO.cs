using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model.enums;

namespace Tools_Renting_System_Information.model.database
{
    interface SalesDAO
    {
        bool rentEquipo(Equipo equipo);
        List<Sales> getSalesByMonth(int year, Month month);
        List<Sales> getSalesByYear(int year);
        List<Sales> getSalesByDay(int year, Month month, int day);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tools_Renting_System_Information.view.userControl.UcIngresoEgreso
{
    interface IUcIngresoEgreso
    {
        void displayReport(UserControl userControl, string typeReporte);
        void displayMessage(string message);
    }
}

using Syncfusion.Windows.Forms.Tools.MultiColumnTreeView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model.pocos;

namespace Tools_Renting_System_Information.model.database.DAOInterfaces
{
    interface SucursalDAO
    {
        List<Sucursal> getSucursalList();
        bool addSucursal(Sucursal sucursal);
        bool removeSucursal(Sucursal sucursal);
        bool editSucursal(Sucursal sucursal);

        Sucursal getSucursal(int sucursalId);
    }
}

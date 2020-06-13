using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools_Renting_System_Information.view.userControl.UcIngresoEgreso
{
    class UcIngresoEgresoPresenter
    {
        IUcIngresoEgreso form;
        public UcIngresoEgresoPresenter(IUcIngresoEgreso form)
        {
            this.form = form;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools_Renting_System_Information.view;
using Tools_Renting_System_Information.view.userControl;
using Tools_Renting_System_Information.presenter;

namespace Tools_Renting_System_Information.model.userControl
{
    public partial class UcAlquilar : UserControl, IUcAlquilarEquipo
    {
        AlquilarEquipoPresenter presenter;
        #region Singleton Getter

        private static UcAlquilar _instance;

        public static UcAlquilar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UcAlquilar();
                }
                return _instance;

            }
        }
        #endregion
        public UcAlquilar()
        {
            InitializeComponent();
            this.presenter = new AlquilarEquipoPresenter(this);
            presenter.getEquipos("");
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            presenter.getEquipos(this.textBoxSearch.Text);
        }

        public void displayEquiposItem(List<UcItemEquipo> itemsList)
        {
            this.flowLayout.Controls.Clear();
            foreach(UcItemEquipo item in itemsList)
            {
                this.flowLayout.Controls.Add(item);
            }
        }
    }
}

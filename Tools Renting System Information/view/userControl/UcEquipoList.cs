using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools_Renting_System_Information.model;
using Tools_Renting_System_Information.view.forms;
using Tools_Renting_System_Information.view.viewsInterface;
using Tools_Renting_System_Information.presenter;
using Tools_Renting_System_Information.model.userControl;

namespace Tools_Renting_System_Information.view.userControl
{
    public partial class UcEquipoList : UserControl, IUcEquipoList
    {
        private EquipoListPresenter presenter;
        #region Singleton Getter

        private static UcEquipoList _instance;

        public static UcEquipoList Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UcEquipoList();
                }
                return _instance;

            }
        }
        #endregion
        private UcEquipoList()
        {
            InitializeComponent();
            presenter = new EquipoListPresenter(this);
        }

        public void displayMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void listEquipos(List<Equipo> equipoList)
        {
            dataGrid.DataSource = equipoList;
        }

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Equipo equipo = (Equipo)dataGrid.CurrentRow.DataBoundItem;
            Form form = new ItemDetailForm<Equipo>(ref equipo);
            form.Show();
        }

        private void UcEquipoList_Enter(object sender, EventArgs e)
        {
            presenter.getEquipoList();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Equipo equipo = (Equipo)dataGrid.CurrentRow.DataBoundItem;
            Form form = new ItemEditForm<Equipo>(ref equipo);
            form.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            
            ((MainForm)ParentForm).DisplayUserControl(UcHome.Instance);
        }
    }
}

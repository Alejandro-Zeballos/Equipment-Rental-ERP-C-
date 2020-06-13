using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools_Renting_System_Information.model;
using Tools_Renting_System_Information.model.database;
using Tools_Renting_System_Information.model.database.DAOInterfaces;
using Tools_Renting_System_Information.model.database.DAOs;
using Tools_Renting_System_Information.model.userControl;
using Tools_Renting_System_Information.presenter;
using Tools_Renting_System_Information.view.userControl;

namespace Tools_Renting_System_Information.view.forms
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            loadGlobals();
            DisplayUserControl(UcHome.Instance);

        }

        public UserControl prevUserControl { get; set; }
        void loadGlobals()
        {
            UserDAO userDAO = new MySqlUserDAO();
            CustomerDAO customerDAO = new MySqlCustomerDAO();
            EquipoDAO equipoDAO = new MySqlEquipoDAO();
            SucursalDAO sucursalDAO = new MySqlSUcursalDAO();

            Utils.usersGlobal = userDAO.getUsersList();
            Utils.customersGlobal = customerDAO.getCustomerList();
            Utils.equiposGlobal = equipoDAO.getEquiposList();
            Utils.SucursalsGlobal = sucursalDAO.getSucursalList();
            Utils.thisSucursal = Utils.SucursalsGlobal[0];
            Utils.currentCustomer = null;
        }

        public void buttonHome_Click(object sender, EventArgs e)
        {
            DisplayUserControl(UcHome.Instance);
        }

        public void DisplayUserControl(UserControl userControl)
        {
            if (userControl.GetType() != typeof(UcAddCustomer))
                prevUserControl = userControl;

            if (!container.Controls.Contains(userControl))
            {
 
                container.Controls.Add(userControl);
                userControl.Dock = DockStyle.Fill;
            }

            userControl.BringToFront();
            userControl.Focus();
        }

        void buttonAlquilar_Click(object sender, EventArgs e)
        {
            DisplayUserControl(UcAlquilar.Instance);
        }

        private void agregarEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayUserControl(UcAddEquipo.Instance);
        }

        private void buttonAgregarCliente_Click(object sender, EventArgs e)
        {
            
            DisplayUserControl(UcAddCustomer.Instance);
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            DisplayUserControl(UcSearchCustomer.Instance);
        }

        private void listarEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayUserControl(UcEquipoList.Instance);
        }

        private void buttonEgreso_Click(object sender, EventArgs e)
        {
            DisplayUserControl(UcInsertEgreso.Instance);
        }

        private void inversoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DisplayUserControl(UcInvestors.Instance);
        }
    }
}

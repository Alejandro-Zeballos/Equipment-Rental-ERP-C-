using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools_Renting_System_Information.presenter;
using Tools_Renting_System_Information.model;
using Tools_Renting_System_Information.view.forms;
using MySqlX.XDevAPI;

namespace Tools_Renting_System_Information.view.userControl
{
    public partial class UcSearchCustomer : UserControl, IUcSearchCustomer
    {
        #region Singleton Getter
        private static UcSearchCustomer _instance;
        public static UcSearchCustomer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UcSearchCustomer();
                }
                return _instance;

            }
        }
        #endregion
        private bool isNameChecked;
        public UserControl previusUserControl { get; set; }
        SearchCustomerPresenter presenter;
        private UcSearchCustomer()
        {
            InitializeComponent();
            presenter = new SearchCustomerPresenter(this);
            isNameChecked = true;
        }

        public void DisplayCustomers(List<Customer> customers)
        {
            this.dataGrid.DataSource = customers;
            
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if ( dataGrid.SelectedRows != null )
            {
                Utils.currentCustomer = (Customer)dataGrid.CurrentRow.DataBoundItem;
                if(previusUserControl!=null)
                    ( (MainForm)ParentForm ).DisplayUserControl(previusUserControl);
                else
                    ((MainForm)ParentForm).DisplayUserControl(Tools_Renting_System_Information.model.userControl.UcHome.Instance);
            }
        }

        private void radioCarnet_CheckedChanged(object sender, EventArgs e)
        {
            isNameChecked = false;
        }

        private void radioNombre_CheckedChanged(object sender, EventArgs e)
        {
            isNameChecked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            presenter.listCustomers(textBox1.Text, isNameChecked);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ((MainForm)ParentForm).DisplayUserControl(UcAddCustomer.Instance);
        }
    }
}

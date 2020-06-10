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
using Syncfusion.Styles;
using Tools_Renting_System_Information.presenter;
using Tools_Renting_System_Information.view.forms;
using Tools_Renting_System_Information.model.userControl;

namespace Tools_Renting_System_Information.view.userControl
{
    public partial class UcAddCustomer : UserControl, IUcAgregarCliente
    {
        #region Singleton Getter
        private static UcAddCustomer _instance;
        public static UcAddCustomer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UcAddCustomer();
                }
                return _instance;

            }
        }
        #endregion

        AddCustomerPresenter presenter;
        private UcAddCustomer()
        {
            InitializeComponent();
            presenter = new AddCustomerPresenter(this);
        }

        public void displayMessage(string message)
        {
            MessageBox.Show(message);
            MainForm mainForm = ((MainForm)ParentForm);

            mainForm.DisplayUserControl(mainForm.prevUserControl);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!areInputsValids())
            {
                MessageBox.Show("Fill up the gaps");
                return;
            }
            string name = this.textBoxName.Text;
            string carnet = this.textBoxCarnet.Text;
            string address = this.textBoxAddress.Text;
            string phone = this.textBoxTelefono.Text;
            string email = this.textBoxEmail.Text;

            Customer customer = new Customer(name, email, carnet, address, phone);

            presenter.AddCustomer(customer);

        }

        private bool areInputsValids()
        {
            //TODO WORK ON THIS
            return true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            emptyTextBoxes();
            ((MainForm)ParentForm).DisplayUserControl(UcHome.Instance);
        }

        public void emptyTextBoxes()
        {
            this.textBoxName.Text = "";
            this.textBoxAddress.Text = "";
            this.textBoxCarnet.Text = "";
            this.textBoxEmail.Text = "";
            this.textBoxTelefono.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools_Renting_System_Information.view.viewsInterface;
using Tools_Renting_System_Information.view.forms;
using Tools_Renting_System_Information.model;
using Tools_Renting_System_Information.presenter;

namespace Tools_Renting_System_Information.view.userControl
{
    public partial class UcEditCustomer : UserControl, IUcEditCustomer
    {
        private EditCustomerPresenter presenter;
        private Customer customer;
        public UcEditCustomer(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            this.presenter = new EditCustomerPresenter(this);
            InitializeFields();
        }

        private void InitializeFields()
        {
            this.textBoxName.Text = customer.name;
            this.textBoxAddress.Text = customer.address;
            this.textBoxCarnet.Text = customer.carnet;
            this.textBoxEmail.Text = customer.email;
            this.textBoxTelefono.Text = customer.phone;
        }

        public void close()
        {
            ((ItemEditForm<Customer>)ParentForm).Dispose();
        }

        public void displayMessage(string message)
        {
            MessageBox.Show(message);
        }

        private bool areInputsValid()
        {
            //TODO: work on this
            return true;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (areInputsValid())
            {
                customer.name = textBoxName.Text;
                customer.address = textBoxAddress.Text;
                customer.carnet = textBoxCarnet.Text;
                customer.email = textBoxEmail.Text;
                customer.phone = textBoxTelefono.Text;

                presenter.EditCustomer(customer);
            }
            else
            {
                MessageBox.Show("Inputs are incorrect");
            }
                
        }
    }
}

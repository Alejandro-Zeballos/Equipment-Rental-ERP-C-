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
using Tools_Renting_System_Information.presenter;

namespace Tools_Renting_System_Information.view.userControl
{
    public partial class UcCustomerDetails : UserControl, IUcCustomerDetails
    {
        private Customer customer;
        private CustomerDetailsPresenter presenter;
        public UcCustomerDetails(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            presenter = new CustomerDetailsPresenter(this);
            
            presenter.getHistorialAlquileres(customer);
            presenter.getToReturnList(customer);

            this.textBoxName.Text = customer.name;
            this.textBoxAddress.Text = customer.address;
            this.textBoxCarnet.Text = customer.carnet;
            this.textBoxEmail.Text = customer.email;
            this.textBoxPhone.Text = customer.phone;

        }

        public void ListHistorialAlquileres(List<RentedEquipo> equipos)
        {
            this.dataGridAlquileres.DataSource = equipos;
        }

        public void ListToReturnEquipos(List<RentedEquipo> equipos)
        {
            this.dataGridToReturn.DataSource = equipos;
        }

        public void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            presenter.selectCustomer(customer);
        }

        public void CloseForm()
        {
            ((ItemDetailForm<Customer>)ParentForm).Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools_Renting_System_Information.model;
using Tools_Renting_System_Information.model.database;
using Tools_Renting_System_Information.view;

namespace Tools_Renting_System_Information.presenter
{
    class AddCustomerPresenter
    {
        IUcAgregarCliente form;
        
        public AddCustomerPresenter(IUcAgregarCliente form)
        {
            this.form = form;
        }

        public void AddCustomer(Customer customer)
        {
            CustomerDAO customerDao = new MySqlCustomerDAO();
            bool isSaved = customerDao.saveCustomer(customer);

            if (isSaved)
            {
                form.emptyTextBoxes();
                form.displayMessage("User saved succesfully!");
            }
            else
            {
                form.displayMessage("User could not be saved :(");
            }
        }
    }
}

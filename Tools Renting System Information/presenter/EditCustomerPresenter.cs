using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model;
using Tools_Renting_System_Information.model.database;
using Tools_Renting_System_Information.view.viewsInterface;

namespace Tools_Renting_System_Information.presenter
{
    class EditCustomerPresenter
    {
        IUcEditCustomer form;
        public EditCustomerPresenter(IUcEditCustomer form)
        {
            this.form = form;
        }

        public void EditCustomer(Customer customer)
        {
            CustomerDAO customerDao = new MySqlCustomerDAO();
            bool success = customerDao.editCustomer(customer);
            if (success)
            {
                form.displayMessage("User saved successfully");
                form.close();
            }
            else
            {
                form.displayMessage("Something happend, try again later");
            }
        }
    }
}

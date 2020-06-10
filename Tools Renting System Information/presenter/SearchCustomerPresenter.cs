using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model;
using Tools_Renting_System_Information.view;

namespace Tools_Renting_System_Information.presenter
{
    class SearchCustomerPresenter
    {
        IUcSearchCustomer form;
        public SearchCustomerPresenter(IUcSearchCustomer form)
        {
            this.form = form;
        }

        public void listCustomers(string matches, bool byName)
        {
            List<Customer> customerList = new List<Customer>();
            if (byName)
            {
                foreach (Customer customer in Utils.customersGlobal)
                {
                    if (customer.name.ToLower().Contains(matches.ToLower()))
                        customerList.Add(customer);
                }
            }
            else
            {
                foreach(Customer customer in Utils.customersGlobal)
                {
                    if (customer.carnet.Contains(matches))
                        customerList.Add(customer);
                }
            }

            form.DisplayCustomers(customerList);
            
        }

        
    }
}

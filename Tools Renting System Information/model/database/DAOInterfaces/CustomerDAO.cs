using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools_Renting_System_Information.model.database
{
    interface CustomerDAO
    {
        bool saveCustomer(Customer customer);
        Customer getCustomer(int id);
        bool deleteCustomer(Customer customer);
        List<Customer> getCustomerList();
        bool editCustomer(Customer customerEdited);
    }
}

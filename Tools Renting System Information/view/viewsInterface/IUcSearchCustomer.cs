using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model;

namespace Tools_Renting_System_Information.view
{
    interface IUcSearchCustomer
    {
        void DisplayCustomers(List<Customer> customers);
    }
}

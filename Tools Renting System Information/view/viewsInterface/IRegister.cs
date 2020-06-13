using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools_Renting_System_Information.view
{
    interface IRegister
    {
        string getName();
        string getEmail();
        string getPhone();
        string getPassword();
        void close();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools_Renting_System_Information.view
{
    interface ILogin
    {
        string getUsername();
        string getPassword();
        void close();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model;
using Tools_Renting_System_Information.model.userControl;

namespace Tools_Renting_System_Information.view
{
    public interface IUcHome
    {
        void displayToReturnItems(List<UcItemRented> ucItemList);
        void displayMessage(string message);
        
    }
}

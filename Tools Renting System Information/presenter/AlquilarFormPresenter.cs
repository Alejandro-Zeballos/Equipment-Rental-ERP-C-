using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model;
using Tools_Renting_System_Information.model.database;
using Tools_Renting_System_Information.model.enums;
using Tools_Renting_System_Information.model.userControl;
using Tools_Renting_System_Information.view;
using Tools_Renting_System_Information.view.forms;

namespace Tools_Renting_System_Information.presenter
{
    class AlquilarFormPresenter
    {
        IUcAlquilarForm form;
        EquipoRentedDAO equipoRentedDAO;
        public AlquilarFormPresenter(IUcAlquilarForm form)
        {
            this.form = form;
            equipoRentedDAO = new MySqlRentedEquipoDAO();
        }

        public void getEquiposAvailable(string type)
        {
            Enum.TryParse(type, out eTypeEquipo typeEquipo);
            List<Equipo> equipoList = new List<Equipo>();
            foreach(Equipo equipo in Utils.equiposGlobal)
            {
                if (equipo.type == typeEquipo & equipo.isAvailable==true)
                    equipoList.Add(equipo);
            }

            form.listAvailableEquipos(equipoList);
        }

        internal void calculatePrice(Equipo equipo, int quantity, bool perHour)
        {
            int totalPrice = 0;
            int unitPrice = 0;
            if (perHour)
            {
                unitPrice = equipo.hourlyPrice;      
            }
            else
            {
                unitPrice = equipo.hourlyPrice * 12;
   
            }

            totalPrice = unitPrice * quantity;

            form.fillUpImportes(unitPrice, totalPrice);
        }

        internal void alquilarEquipo(Equipo equipo, DateTime time, int importeTotal)
        {
            string currentDate = Utils.getCurrentDateTime();
            string dateReturn = Utils.getDateTime(time);
            RentedEquipo rentedEquipo = new RentedEquipo(equipo.id, Utils.currentCustomer.id, Program.user.id, 1, importeTotal, dateReturn, currentDate, false);
            bool saleSaved = equipoRentedDAO.saveRentedEquipo(rentedEquipo);

            if (saleSaved)
            {
                form.displayMessage("Sale saved successfully");
                UcHome.Instance.presenter.getToReturnList();
                getEquiposAvailable(equipo.type.ToString());
            }
            else
            {
                form.displayMessage("Something went wrong");
            }
                
            
        }
    }
}

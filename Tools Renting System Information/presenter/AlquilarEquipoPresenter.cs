using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model.enums;
using Tools_Renting_System_Information.view;
using Tools_Renting_System_Information.view.userControl;

namespace Tools_Renting_System_Information.presenter
{
    
    public class AlquilarEquipoPresenter
    {
        IUcAlquilarEquipo Form;
        List<UcItemEquipo> ItemEquipoList;
        public AlquilarEquipoPresenter(IUcAlquilarEquipo form)
        {
            this.Form = form;
            this.ItemEquipoList = generateItems();
        }

        private List<UcItemEquipo> generateItems()
        {

            List<UcItemEquipo> theEquipoList = new List<UcItemEquipo>(); 
            IEnumerable<eTypeEquipo> typeList = Enum.GetValues(typeof(eTypeEquipo)).Cast<eTypeEquipo>();
            string path = "C:\\Users\\Alejandro\\source\\repos\\Tools Renting System Information\\Tools Renting System Information\\model\\resources\\icons8-rain-64.png";
            foreach (eTypeEquipo type in typeList)
            {
                UcItemEquipo item = new UcItemEquipo(this );
                item.EquipoName = type.ToString();
                item.Img = path;
                theEquipoList.Add(item);
                
            }

            return theEquipoList;
        }

        public void getEquipos(string match)
        {
            List<UcItemEquipo> itemsToDisplay = new List<UcItemEquipo>();
            foreach(UcItemEquipo item in this.ItemEquipoList)
            {
                if (item.EquipoName.ToLower().Contains(match.ToLower()))
                {
                    itemsToDisplay.Add(item);
                }
            }

            Form.displayEquiposItem(itemsToDisplay);
        }

        public void ItemClicked(string type)
        {
            
        }



    }
}

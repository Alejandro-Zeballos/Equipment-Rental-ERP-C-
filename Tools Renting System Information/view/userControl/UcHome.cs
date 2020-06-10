using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools_Renting_System_Information.presenter;
using Tools_Renting_System_Information.view;
using Tools_Renting_System_Information.model;
using Syncfusion.Windows.Forms;

namespace Tools_Renting_System_Information.model.userControl
{
    public partial class UcHome : UserControl,IUcHome
    {
        public HomePresenter presenter;

        #region Singleton Getter
        private static UcHome _instance;
        public static UcHome Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new UcHome();
                }
                return _instance;
                
            }
        }
        #endregion

        public UcHome()
        {
            InitializeComponent();
            presenter = new HomePresenter(this);
            presenter.getToReturnList();
        }


        public void displayToReturnItems(List<UcItemRented> ucItemList)
        {
            flowLayout.Controls.Clear();
            foreach (UcItemRented item in ucItemList)
            {

                flowLayout.Controls.Add(item);
                //TODO: aplicar tests a mis 

            }
        }

        public void displayMessage(string message)
        {
            MessageBox.Show(message);
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools_Renting_System_Information.model;
using Tools_Renting_System_Information.model.enums;
using Tools_Renting_System_Information.presenter;
using Tools_Renting_System_Information.view.viewsInterface;
using Tools_Renting_System_Information.view.forms;

namespace Tools_Renting_System_Information.view.userControl
{
    public partial class UcEquipoDetail : UserControl, IUcEquipoDetail
    {

        private Equipo equipo;
        private EquipoDetailPresenter presenter;
        public UcEquipoDetail(Equipo equipo)
        {
            this.equipo = equipo;
            this.presenter = new EquipoDetailPresenter(this);
            InitializeComponent();
            InitializeFields();
            
            
        }

        public void displayMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void listRentingHistory(List<RentedEquipo> rentedEquiposList)
        {
            this.dataGrid.DataSource = rentedEquiposList;
        }

        private void InitializeFields()
        {
            if (equipo.isAvailable)
                this.textBoxAvailable.Text = "Si";
            else 
                this.textBoxAvailable.Text = "No";
            //TODO: change this, have a Utils get branch method for this
            this.textBoxBodega.Text = "Colcapirhua";
            this.textBoxDate.Text = equipo.dateBought;
            this.textBoxDescription.Text = equipo.description;
            this.textBoxModelo.Text = equipo.model;
            this.textBoxPrecio.Text = equipo.priceItem.ToString();
            this.textBoxPrecioHora.Text = equipo.hourlyPrice.ToString();
            this.textBoxTipoEquipo.Text = Enum.GetName(typeof(eTypeEquipo), equipo.type);

            presenter.getRentalHistory(equipo);
        }

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RentedEquipo rentedEquipo = (RentedEquipo)dataGrid.CurrentRow.DataBoundItem;
            Form form = new ItemDetailForm<RentedEquipo>(ref rentedEquipo);
            form.Show();
        }
    }
}

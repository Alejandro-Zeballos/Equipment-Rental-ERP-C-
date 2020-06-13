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
using Tools_Renting_System_Information.view.forms;

namespace Tools_Renting_System_Information.view.userControl
{
    public partial class UcEquipoRentedDetail : UserControl
    {
        private RentedEquipo rentedEquipo;

        public UcEquipoRentedDetail(RentedEquipo rentedEquipo)
        {
            InitializeComponent();
            this.rentedEquipo = rentedEquipo;
            InitializeFields();
        }

        private void InitializeFields()
        {
            User user = Utils.getUser(rentedEquipo.idUser);
            Equipo equipo = Utils.getEquipo(rentedEquipo.idEquipo);
            Customer customer = Utils.getCustomer(rentedEquipo.idCustomer);
            textBoxEquipo.Text = equipo.ToString();
            textBoxCustomer.Text = customer.name;
            textBoxUsuario.Text = user.name;
            textBoxDateRented.Text = rentedEquipo.dateRented;
            textBoxDateReturn.Text = rentedEquipo.dateReturn;
            textBoxQuantity.Text = rentedEquipo.quantity.ToString();
            textBoxTotal.Text = rentedEquipo.importe.ToString();
            if (rentedEquipo.isReturned)
                textBoxIsReturned.Text = "Si";
            else textBoxIsReturned.Text = "No";

        }

        private void textBoxEquipo_Click(object sender, EventArgs e)
        {
            Equipo equipo = Utils.getEquipo(rentedEquipo.idEquipo);
            Form form = new ItemDetailForm<Equipo>(ref equipo);
            form.Show();
        }
    }
}

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
using Tools_Renting_System_Information.view.viewsInterface;
using Tools_Renting_System_Information.view.forms;
using Tools_Renting_System_Information.presenter;

namespace Tools_Renting_System_Information.view.userControl
{
    public partial class UcEditEquipo : UserControl,IUcEditarEquipo
    {
        private Equipo equipo;
        private EditEquipoPresenter presenter;
        public UcEditEquipo(Equipo equipo)
        {
            InitializeComponent();
            this.equipo = equipo;
            this.presenter = new EditEquipoPresenter(this);
            InitializeFields();
            
        }

        public void close()
        {
            ((ItemDetailForm<Equipo>)ParentForm).Dispose();
        }

        public void displayMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void InitializeFields()
        {
            this.textBoxModelo.Text = equipo.model;
            this.textBoxDescription.Text = equipo.description;
            this.textBoxPrecio.Text = equipo.priceItem.ToString();
            this.textBoxPrecioHora.Text = equipo.hourlyPrice.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (inputsAreValid())
            {
                equipo.model = this.textBoxModelo.Text;
                equipo.description = this.textBoxDescription.Text;
                equipo.priceItem = Int32.Parse(this.textBoxPrecio.Text);
                equipo.hourlyPrice = Int32.Parse(this.textBoxPrecioHora.Text);

                presenter.EditEquipo(equipo);
            }
            else
            {
                MessageBox.Show("Inputs are invalid");
            }


        }

        private bool inputsAreValid()
        {
            //work on this
            return true;
        }
    }
}

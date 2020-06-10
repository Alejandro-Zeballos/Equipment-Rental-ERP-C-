using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools_Renting_System_Information.model.enums;
using Tools_Renting_System_Information.model;
using Tools_Renting_System_Information.presenter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Tools_Renting_System_Information.view.forms;
using Tools_Renting_System_Information.model.userControl;

namespace Tools_Renting_System_Information.view.userControl
{
    public partial class UcAddEquipo : UserControl, IUcAddEquipo
    {
        AddEquipoPresenter presenter;

        #region Singleton Getter
        private static UcAddEquipo _instance;
        public static UcAddEquipo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UcAddEquipo();
                }
                return _instance;

            }
        }
        #endregion
        private UcAddEquipo()
        {
            InitializeComponent();
            InitializeComboBox();
            
            presenter = new AddEquipoPresenter(this);
        }

        private void InitializeComboBox()
        {
            comboBoxType.DataSource = System.Enum.GetValues(typeof(eTypeEquipo));
            comboBoxBodega.DataSource = System.Enum.GetValues(typeof(eSucursal));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!areInputsValids())
            {
                MessageBox.Show("Fill up the gaps");
                return;
            }
            int idSucursal = Utils.thisSucursal.id;
            eTypeEquipo type = (eTypeEquipo)Enum.Parse(typeof(eTypeEquipo), comboBoxType.SelectedValue.ToString());
            string modelo = textBoxModelo.Text;
            DateTime date = datePicker.Value;
            string stringDate = date.ToString("yyyy'-'MM'-'dd");
            Console.WriteLine("Date is: " + date);
            string desc = textBoxDescription.Text;
            int precio = Int32.Parse(textBoxPrecio.Text);
            int horaPrecio = Int32.Parse(textBoxPrecioHora.Text);
            Equipo equipo = new Equipo(idSucursal, modelo, type, stringDate, desc, precio, horaPrecio);

            presenter.addEquipo(equipo);
        }

        private bool areInputsValids()
        {
            //TODO: work in this validations
            return true;
        }

        public void displayMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            emptyTextBoxes();
            ( (MainForm) ParentForm ).DisplayUserControl(UcHome.Instance);
            
        }

        public void emptyTextBoxes()
        {
            this.textBoxDescription.Text = "";
            this.textBoxModelo.Text = "";
            this.textBoxPrecio.Text = "";
            this.textBoxPrecioHora.Text = "";
        }
    }
}

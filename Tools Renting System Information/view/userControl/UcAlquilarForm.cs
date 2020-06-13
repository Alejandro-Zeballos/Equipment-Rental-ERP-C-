using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools_Renting_System_Information.view.forms;
using Tools_Renting_System_Information.model.userControl;
using Tools_Renting_System_Information.model;
using Tools_Renting_System_Information.presenter;

namespace Tools_Renting_System_Information.view.userControl
{
    public partial class UcAlquilarForm : UserControl, IUcAlquilarForm
    {
        #region Singleton Getter
        private static UcAlquilarForm _instance;
        public static UcAlquilarForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UcAlquilarForm();
                }
                return _instance;

            }
        }
        #endregion

        AlquilarFormPresenter presenter;
        bool perHour;
        Equipo equipo;
        public UcAlquilarForm()
        {
            InitializeComponent();
            this.presenter = new AlquilarFormPresenter(this);
            this.perHour = true;
           
        }

        public void setTypeEquipo(string type)
        {
            this.labelEquipoName.Text = type;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ((MainForm)ParentForm).DisplayUserControl(UcHome.Instance);
        }

        private void textBoxCliente_Click(object sender, EventArgs e)
        {
            UcSearchCustomer userControl = UcSearchCustomer.Instance;
            userControl.previusUserControl = this;
            ((MainForm)ParentForm).DisplayUserControl(userControl);
        }

        private void UcAlquilarForm_Enter(object sender, EventArgs e)
        {
            //Utils.UpdateEquipos();
            presenter.getEquiposAvailable(labelEquipoName.Text);

            if(Utils.currentCustomer != null)
                this.textBoxCliente.Text = Utils.currentCustomer.name;
        }

        public void listAvailableEquipos(List<Equipo> equipoList)
        {
            this.dataGrid.DataSource = equipoList;
        }

        public void displayMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void fillUpCustomerName(string name)
        {
            this.textBoxCliente.Name = name;
        }

        private void textBoxHorasDias_TextChanged(object sender, EventArgs e)
        {
            int i;
            if(!Int32.TryParse(textBoxHorasDias.Text, out i))
            {
                displayMessage("Sorry but I only accept numbers integers");
                return;
            }
            
            equipo = ((Equipo)dataGrid.CurrentRow.DataBoundItem);
            presenter.calculatePrice(equipo, Int32.Parse(textBoxHorasDias.Text), perHour);
        }

        private void radioHora_CheckedChanged(object sender, EventArgs e)
        {
            this.perHour = true;
        }

        private void radioDia_CheckedChanged(object sender, EventArgs e)
        {
            this.perHour = false;
        }

        public void fillUpImportes(int unitImporte, int totalImporte)
        {
            this.textBoxImporteDia.Text = unitImporte.ToString();
            this.textBoxImporteTotal.Text = totalImporte.ToString();
        }

        private void buttonAlquilar_Click(object sender, EventArgs e)
        {
            if (areInputsValid())
            {
                Equipo equipoSelected = (Equipo)this.dataGrid.CurrentRow.DataBoundItem;
                int importeTotal = Int32.Parse(this.textBoxImporteTotal.Text);
                presenter.alquilarEquipo(equipoSelected, datePicker.Value, importeTotal);

            }
                
        }


        private bool areInputsValid()
        {
            bool inputsAreValid = true;
            if (textBoxCliente.Text.Length == 0)
                inputsAreValid = false;
            if (textBoxHorasDias.Text.Length == 0)
                inputsAreValid = false;
            if (datePicker.Value <= DateTime.Now)
                inputsAreValid = false;

            return inputsAreValid;
        }

        private void dataGrid_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Equipo equipo = (Equipo)dataGrid.CurrentRow.DataBoundItem;
            Form form = new ItemDetailForm<Equipo>(ref equipo);
            form.Show();
        }
    }
}

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
using Tools_Renting_System_Information.model.enums.egresos;
using Tools_Renting_System_Information.view.viewsInterface;
using Tools_Renting_System_Information.model.pocos;
using Tools_Renting_System_Information.model;
using Tools_Renting_System_Information.presenter;
using Tools_Renting_System_Information.view.forms;
using Tools_Renting_System_Information.model.userControl;

namespace Tools_Renting_System_Information.view.userControl
{
    public partial class UcInsertEgreso : UserControl, IUcInsertEgreso
    {
        InsertEgresoPresenter presenter;
        #region Singleton Getter

        private static UcInsertEgreso _instance;

        public static UcInsertEgreso Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UcInsertEgreso();
                }
                return _instance;

            }
        }
        #endregion
        public UcInsertEgreso()
        {
            InitializeComponent();
            InitializeComboBox();
            presenter = new InsertEgresoPresenter(this);
        }

        private void InitializeComboBox()
        {
            comboBoxEgreso.DataSource = Enum.GetValues(typeof(Egresos));
            listSubEgresos();
        }

        private void listSubEgresos()
        {
            switch (Enum.GetName(typeof(Egresos),comboBoxEgreso.SelectedItem))
            {
                case "ADMINISTRATIVO":
                    comboBoxSubEgreso.DataSource = Enum.GetValues(typeof(EgresoAdministrativo));
                    break;
                case "OPERATIVO":
                    comboBoxSubEgreso.DataSource = Enum.GetValues(typeof(EgresoOperativo));
                    break;
                case "FIJO":
                    comboBoxSubEgreso.DataSource = Enum.GetValues(typeof(EgresoFijo));
                    break;
            }
        }

        private void comboBoxEgreso_SelectedValueChanged(object sender, EventArgs e)
        {
            listSubEgresos();
        }

        public void displayMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void clearTextFields()
        {
            textBoxRecibo.Text = "";
            textBoxDetalle.Text = "";
            textBoxTotal.Text = "";
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if (areInputsValid())
            {
                Egresos typeEgreso = (Egresos)comboBoxEgreso.SelectedItem;
                string subEgresoString = comboBoxSubEgreso.SelectedItem.ToString();
                Type subEgresoType = Utils.getTypeOfEnum(subEgresoString);
                Enum typeSubEgreso = (Enum)Enum.Parse(subEgresoType,subEgresoString);
                string recibo = textBoxRecibo.Text;
                string description = textBoxDetalle.Text;
                string date = Utils.getCurrentDateTime();
                int idUser = Program.user.id;
                int idBranch = Utils.thisSucursal.id;
                int total = Int32.Parse(textBoxTotal.Text);
                
                Egreso egreso = new Egreso(typeEgreso, typeSubEgreso, recibo, date
                                            , idUser, idBranch, description, total);

                presenter.InsertEgreso(egreso);

            }
            else
            {
                MessageBox.Show("Inputs are not valid");
            }
        }

        private bool areInputsValid()
        {
            //todo: hacer esta parte joder
            return true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ((MainForm)ParentForm).DisplayUserControl(UcHome.Instance);
        }
    }
}

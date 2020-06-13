using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools_Renting_System_Information.view.viewsInterface;
using Tools_Renting_System_Information.model.pocos;
using Tools_Renting_System_Information.presenter;
using Tools_Renting_System_Information.model;
using Microsoft.VisualBasic;

namespace Tools_Renting_System_Information.view.userControl
{
    public partial class UcInvestors : UserControl, IUcInvestors
    {
        InvestorsPresenter presenter;

        #region Singleton Getter
        private static UcInvestors _instance;
        public static UcInvestors Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UcInvestors();
                }
                return _instance;

            }
        }
        #endregion
        private UcInvestors()
        {
            presenter = new InvestorsPresenter(this);
            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            presenter.getInvestorList();
            presenter.getInvestorFields((Investor)this.comboBoxInversores.SelectedItem);
        }

        public void clearTextFields()
        {
            textBoxInvertir.Text = "";
            textBoxRetirar.Text = "";
        }

        public void displayMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void populateDataGrid(List<InvestorActivity> activities)
        {
            this.dataGrid.DataSource = activities;
        }

        public void populateFields(Investor investor)
        {
            textBoxTotalInvest.Text = investor.totalInvest.ToString();
            textBoxTotalRetiro.Text = investor.totalRetiros.ToString();
            //TODO: TRABAJAR EN ESTO DEL SALDO.. create a new report service
            textBoxSaldo.Text = (investor.totalInvest - investor.totalRetiros).ToString();
        }

        public void populateComboBox(List<Investor> investorList)
        {
            this.comboBoxInversores.DataSource = investorList;
        }

        private void comboBoxInversores_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.getInvestorFields((Investor)this.comboBoxInversores.SelectedItem);
        }

        private void buttonInvest_Click(object sender, EventArgs e)
        {
            if (isInputOk(textBoxInvertir.Text)) { }
            string desc = getDescription();
            int idInvestor = ((Investor)comboBoxInversores.SelectedItem).id;
            InvestorActivity activity = new InvestorActivity(idInvestor, model.enums.Activity.INVERSION
                , Int32.Parse(textBoxInvertir.Text), Utils.getCurrentDateTime(), desc);
            
            presenter.saveActivity(activity);
        }

        private bool isInputOk(string text)
        {
            return true;
        }

        private string getDescription()
        {
            string desc = Interaction.InputBox("Escriba una descripcion de la Actividad", "Actividad", "Default", 0, 0);
            return desc;
        }

        private void buttonRetirar_Click(object sender, EventArgs e)
        {
            if (isInputOk(textBoxRetirar.Text)) { }
            string desc = getDescription();
            int idInvestor = ((Investor)comboBoxInversores.SelectedItem).id;
            InvestorActivity activity = new InvestorActivity(idInvestor, model.enums.Activity.INVERSION
                , Int32.Parse(textBoxRetirar.Text), Utils.getCurrentDateTime(), desc);

            presenter.saveActivity(activity);
        }
    }
}

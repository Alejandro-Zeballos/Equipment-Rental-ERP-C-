using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools_Renting_System_Information.presenter;

namespace Tools_Renting_System_Information.view
{
    public partial class RegisterForm : MetroFramework.Forms.MetroForm, IRegister
    {
        RegisterPresenter presenter;
        public RegisterForm()
        {
            this.TopLevel = true;
            InitializeComponent();
            presenter = new RegisterPresenter(this);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (inputsAreValid())
            {
                presenter.registerUser();
            }
            
        }

        private bool inputsAreValid() {

            if(textBoxName.Text.Equals("")||textBoxEmail.Text.Equals("")
                ||textBoxPass.Text.Equals("")||textBoxRepeatPass.Text.Equals("")
                || textBoxRepeatPass.Text.Equals("") || textBoxPhone.Text.Equals(""))
            {
                MessageBox.Show("You have left ");
            }

            return true;
        }

        public string getName()
        {
            return textBoxName.Text;
        }

        public string getEmail()
        {
            return textBoxEmail.Text;
        }

        public string getPhone()
        {
            return textBoxPhone.Text;
        }

        public string getPassword()
        {
            return textBoxPass.Text;
        }

        public void close()
        {

            this.Hide();
            Program.nextForm.Show();
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            presenter.back();

        }
    }
}

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
using Tools_Renting_System_Information.view;

namespace Tools_Renting_System_Information
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm, ILogin
    {
        LoginPresenter presenter;
        public LoginForm()
        {
            this.TopLevel = true;
            InitializeComponent();
            presenter = new LoginPresenter(this);
            
        }

        public void close()
        {
            
            this.Hide();
            Program.nextForm.Show();
            
            
        }

        public string getPassword()
        {
            return "ale";
        }

        public string getUsername()
        {
            return "ale@gmail.com";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            presenter.logIn();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            presenter.register();
        }
    }
}

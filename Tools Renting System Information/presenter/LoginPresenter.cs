using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_Renting_System_Information.model.database;
using Tools_Renting_System_Information.view;
using Tools_Renting_System_Information.model;
using System.Windows.Forms;
using Tools_Renting_System_Information.view.forms;

namespace Tools_Renting_System_Information.presenter
{
    class LoginPresenter
    {
        ILogin loginForm;
        UserDAO userDao;

        public LoginPresenter(ILogin loginForm)
        {
            userDao = new MySqlUserDAO();
            this.loginForm = loginForm;
        }

        public void logIn()
        {
            string username = loginForm.getUsername();
            string password = loginForm.getPassword();
            User user = userDao.loginUser(username, password);
            if (user != null)
            {
                Program.user = user;
                MainForm mainForm = new MainForm();
                Program.nextForm = mainForm;
                loginForm.close();

            }
        }

        public void register()
        {
            
            Form registerForm = new RegisterForm();
            Program.nextForm = registerForm;
            loginForm.close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools_Renting_System_Information.model;
using Tools_Renting_System_Information.model.database;
using Tools_Renting_System_Information.view;

namespace Tools_Renting_System_Information.presenter
{
    class RegisterPresenter
    {
        private IRegister form;
        UserDAO userDao;

        public RegisterPresenter(IRegister form)
        {
            this.form = form;
            userDao = new MySqlUserDAO();
        }

        public void registerUser()
        {
            string name = form.getName();
            string email = form.getEmail();
            string phone = form.getPhone();
            string pass = form.getPassword();
            User newUser = new User(name, email, pass, phone, model.enums.Access.USER);
            if (userDao.registerUser(newUser))
            {
                MessageBox.Show("User created succesfully!");
                Form loginForm = new LoginForm();
                Program.nextForm = loginForm;
                form.close();

            }
            else
            {
                MessageBox.Show("Something happend, user not created");
            }
        }

        public void back()
        {
            Form login = new LoginForm();
            Program.nextForm = login;
            form.close();
        }


    }
}

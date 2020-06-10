using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools_Renting_System_Information.model.database
{
    interface UserDAO
    {
        bool registerUser(User newUser);
        User loginUser(String username, String password);
        bool deleteUser(User user);
        List<User> getUsersList();
        bool editUser(User editedUser);

        User getUser(int id);

    }
}

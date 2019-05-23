using OOP_FileWriting_Example.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FileWriting_Example.Manager {
    class AppUserManager {

        internal bool CheckCredentials(string username, string password) {

            var users = Database.GetUsers();

            foreach (var user in users) {
                if (user.UserName == username && user.Password == password) {
                    return true;
                }
            }

            return false;
        }
    }
}

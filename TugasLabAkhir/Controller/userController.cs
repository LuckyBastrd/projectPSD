using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Handler;
using TugasLabAkhir.Model;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.Controller
{
    public class userController
    {

        public static string registUser(string name, string email, string gender, string password, string role, string confirm)
        {

            if(name.Equals(""))
            {
                return "Name Invalid";
            } else if (!name.EndsWith(".com"))
            {
                return "email must end with '.com'";
            } else if (gender.Equals(""))
            {
                return "must choose gender";
            } else if (password.Equals(""))
            {
                return "Password empty";
            } else if (!password.Equals(confirm))
            {
                return "Password not match";
            } else if (role.Equals(""))
            {
                return "Choose Role";
            }

            return userRepository.registUser(name, email, gender, password, role);
        }

    }
}
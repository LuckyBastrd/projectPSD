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

            if(name.Length < 5 || name.Length > 15 || name.All(x => Char.IsLetter(x) || x == ' ') == false)
            {
                return "Name Invalid";
            } else if (!email.EndsWith(".com"))
            {
                return "email must end with '.com'";
            } else if (gender.Equals(""))
            {
                return "must choose gender";
            } else if (password.Equals(""))
            {
                return "Password empty";
            } else if (!confirm.Equals(password))
            {
                return "Password not match";
            } else if (role.Equals(""))
            {
                return "Choose Role";
            }

            return userHandler.registUser(name, email, gender, password, role);
        }

        public static User login(string name, string password)
        {

            User u = new User();

            if (name == null || password == null)
            {
                return u;
            }

            return userRepository.login(name, password);
        }
    }
}
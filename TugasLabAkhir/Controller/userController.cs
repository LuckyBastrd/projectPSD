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
                return "Name invalid";
            } else if (!email.EndsWith(".com"))
            {
                return "Email must end with '.com'";
            } else if (gender.Equals(""))
            {
                return "Must choose gender";
            } else if (password.Equals(""))
            {
                return "Password empty";
            } else if (!confirm.Equals(password))
            {
                return "Password not match";
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

            return userHandler.login(name, password);
        }

        public static string updateUser(string name, string email, string gender, string password, string confirm)
        {
            if (name.Length < 5 || name.Length > 15 || name.All(x => Char.IsLetter(x) || x == ' ') == false)
            {
                return "Name invalid";
            } else if (!email.EndsWith(".com"))
            {
                return "Email must end with '.com'";
            }

            else if (gender.Equals(""))
            {
                return "Must choose gender";
            } else if (!password.Equals(confirm))
            {
                return "Password not matching";
            }

            return userHandler.updateUser(name, email, gender, password);
        }

        public static List<User> getAllUser(int roleId)
        {
            return userHandler.getAllUser(roleId);
        }

        public static List<User> getUserById(int userId)
        {
            return userHandler.getUserById(userId);
        }

        public static string getStaffName(string staffId)
        {
            return userHandler.getStaffName(staffId);
        }
    }
}
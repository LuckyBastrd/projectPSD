using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Model;

namespace TugasLabAkhir.Factory
{
    public class userFactory
    {
        public static User registUser(string name, string email, string gender, string password, string role)
        {
            User u = new User();

            u.UserName = name;
            u.UserEmail = email;
            u.UserGender = gender;
            u.UserPassword = password;
            u.RoleId = int.Parse(role);

            return u;
        }
    }
}
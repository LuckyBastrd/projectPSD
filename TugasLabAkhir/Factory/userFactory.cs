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

            u.userName = name;
            u.userEmail = email;
            u.userGender = gender;
            u.userPassword = password;
            u.roleID = int.Parse(role);

            return u;
        }
    }
}
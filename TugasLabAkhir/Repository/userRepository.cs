using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Factory;
using TugasLabAkhir.Model;

namespace TugasLabAkhir.Repository
{
    public class userRepository
    {
        public static string registUser(string name, string email, string gender, string password, string role)
        {

            DatabaseEntities db = new DatabaseEntities();

            User u = userFactory.registUser(name, email, gender, password, role);

            db.Users.Add(u);
            db.SaveChanges();

            return "Registration success";
        }

    }
}
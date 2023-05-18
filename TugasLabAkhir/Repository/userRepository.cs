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

            DatabaseEntities3 db = new DatabaseEntities3();

            User u = userFactory.registUser(name, email, gender, password, role);

            db.Users.Add(u);
            db.SaveChanges();

            return "Registration success";
        }

        public static User login(string name, string password)
        {

            DatabaseEntities3 db = new DatabaseEntities3();

            User u = (from x in db.Users where name.Equals(x.UserName) && password.Equals(x.UserPassword) select x).FirstOrDefault();

            return u;
        }
    }
}
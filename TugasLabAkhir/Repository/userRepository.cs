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

            DatabaseEntities4 db = new DatabaseEntities4();

            User u = userFactory.registUser(name, email, gender, password, role);

            db.Users.Add(u);
            db.SaveChanges();

            return "Registration success";
        }

        public static User login(string name, string password)
        {

            DatabaseEntities4 db = new DatabaseEntities4();

            User u = (from x in db.Users where name.Equals(x.UserName) && password.Equals(x.UserPassword) select x).FirstOrDefault();

            return u;
        }

        public static string updateUser(int Id, string name, string email, string gender, string password, string confirmPass)
        {
            DatabaseEntities4 db = new DatabaseEntities4();

            User u = db.Users.Find(Id);

            if (u != null)
            {
                u.UserName = name;
                u.UserEmail = email;
                u.UserGender = gender;

                db.SaveChanges();
            } 

            return "Update Profile Success";   
        }
    }
}
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

        public static User login(string name, string password)
        {

            DatabaseEntities db = new DatabaseEntities();

            User u = (from x in db.Users where name.Equals(x.UserName) && password.Equals(x.UserPassword) select x).FirstOrDefault();

            if(u != null && u.UserName == name && u.UserPassword == password)
            {
                return u;
            }

            return null;
        }

        public static string updateUser(string name, string email, string gender, string password)
        {

            DatabaseEntities db = new DatabaseEntities();

            User u = (from x in db.Users where password.Equals(x.UserPassword) select x).FirstOrDefault();

            if (u != null)
            {
                u.UserName = name;
                u.UserEmail = email;
                u.UserGender = gender;

                db.SaveChanges();

                return "Update Profile Success";
            }
            else
            {
                return "Password incorrect";
            }  
        }

        public static List<User> getAllUser(int roleId)
        {
            DatabaseEntities db = new DatabaseEntities();

            List<User> u = (from x in db.Users where x.RoleId.Equals(roleId) select x).ToList();

            return u;
        }

        public static List<User> getUserById(int userId)
        {
            DatabaseEntities db = new DatabaseEntities();

            List<User> u = (from x in db.Users where x.UserId.Equals(userId) select x).ToList();

            return u;
        }

        public static string getStaffName(string staffId)
        {
            DatabaseEntities db = new DatabaseEntities();

            string staffName = (from x in db.Users where x.UserId.ToString() == staffId select x.UserName).FirstOrDefault();

            return staffName;
        }
    }
}
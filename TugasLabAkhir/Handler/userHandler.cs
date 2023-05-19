using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Model;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.Handler
{
    public class userHandler
    {

        public static string registUser(string name, string email, string gender, string password, string role)
        {
           return userRepository.registUser(name, email, gender, password, role);
        }

        public static User login(string name, string password)
        {
            return userRepository.login(name, password);
        }

        public static string updateUser(int Id, string name, string email, string gender, string password, string confirmPass)
        {
            return userRepository.updateUser(Id, name, email, gender, password, confirmPass);
        }
    }
}
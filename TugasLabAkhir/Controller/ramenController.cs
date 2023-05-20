using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Handler;

namespace TugasLabAkhir.Controller
{
    public class ramenController
    {

        public static string insertRamen(string ramenName, string meat, string broth, string price)
        {

            if (!ramenName.Contains("Ramen"))
            {
                return "Ramen name must contain ramen";
            } else if (meat.Equals(""))
            {
                return "Choose your meat";
            } else if (broth.Equals(""))
            {
                return "Broth can't empty";
            } else if (int.Parse(price) < 3000)
            {
                return "Price must be at least 3000";
            }

            return ramenHandler.insertRamen(ramenName, meat, broth, price);

        }

        public static string updateRamen(string id, string ramenName, string meat, string broth, string price)
        {
            if (!ramenName.Contains("Ramen"))
            {
                return "Ramen name must contain ramen";
            }
            else if (meat.Equals(""))
            {
                return "Choose your meat";
            }
            else if (broth.Equals(""))
            {
                return "Broth can't empty";
            }
            else if (int.Parse(price) < 3000)
            {
                return "Price must be at least 3000";
            }

            return ramenHandler.updateRamen(id, ramenName, meat, broth, price);
        }

        public static Boolean deleteRamen(string id)
        {
            return ramenHandler.deleteRamen(id);
        }

    }
}
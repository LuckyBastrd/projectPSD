using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Factory;
using TugasLabAkhir.Model;

namespace TugasLabAkhir.Repository
{
    public class ramenRepository
    {

        public static string insertRamen(string ramenName, string meat, string broth, string price)
        {

            DatabaseEntities5 db = new DatabaseEntities5();

            Raman r = ramenFactory.createRamen(ramenName, meat, broth, price);

            db.Ramen.Add(r);
            db.SaveChanges();

            return "Ramen Data Inserted";
        }

         

        public static List<Raman> getAllRamen()
        {

            DatabaseEntities5 db = new DatabaseEntities5();

            List<Raman> r = (from x in db.Ramen select x).ToList();

            return r;

        }

    }
}
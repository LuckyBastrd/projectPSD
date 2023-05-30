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

            DatabaseEntities db = new DatabaseEntities();

            Raman r = ramenFactory.createRamen(ramenName, meat, broth, price);

            db.Ramen.Add(r);
            db.SaveChanges();

            return "Ramen Data Inserted";
        }

        public static string updateRamen(string id, string ramenName, string meat, string broth, string price)
        {
            DatabaseEntities db = new DatabaseEntities();

            Raman r = db.Ramen.Find(int.Parse(id));

            if(r != null)
            {
                r.RamenName = ramenName;
                r.MeatId = int.Parse(meat);
                r.Broth = broth;
                r.Price = int.Parse(price);

                db.SaveChanges();

                return "Update Success";
            }
            else
            {
                return "Ramen Id not found";
            }


        } 

        public static Boolean deleteRamen(string id)
        {
            DatabaseEntities db = new DatabaseEntities();

            Raman r = db.Ramen.Find(int.Parse(id));

            if(r != null)
            {
                db.Ramen.Remove(r);

                db.SaveChanges();
            }

            return false;
        } 

        public static List<Raman> getAllRamen()
        {

            DatabaseEntities db = new DatabaseEntities();

            List<Raman> r = (from x in db.Ramen select x).ToList();

            return r;

        }

        public static List<Raman> getRamenById(int ramenId)
        {
            DatabaseEntities db = new DatabaseEntities();

            List<Raman> r = (from x in db.Ramen where x.RamenId.Equals(ramenId) select x).ToList();

            return r;
        }
    }
}
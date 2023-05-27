using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Factory;
using TugasLabAkhir.Model;

namespace TugasLabAkhir.Repository
{
    public class transactionRepository
    {

        public static Header insertTransaction(string userId, string date)
        {

            DatabaseEntities db = new DatabaseEntities();

            Header h = transactionFactory.createHeader(userId, date);

            db.Headers.Add(h);
            db.SaveChanges();

            //int headerId = db.Headers.OrderByDescending(x => x.HeaderId).Select(x => x.HeaderId).FirstOrDefault();
            //h.HeaderId = headerId;

            return h;
        }

        public static int GetLatestHeaderId()
        {
            DatabaseEntities db = new DatabaseEntities();
            
            int headerId = db.Headers.OrderByDescending(x => x.HeaderId).Select(x => x.HeaderId).FirstOrDefault();

            return headerId;
        }

        public static List<Header> getAllHeader(int userId)
        {

            DatabaseEntities db = new DatabaseEntities();



            List<Header> h = (from x in db.Headers where x.UserId.Equals(userId) select x).ToList();

            return h;
        }

    }
}
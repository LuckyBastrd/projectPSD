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

        public static Header showHeader (string userId, string staffId, string date)
        {

            DatabaseEntities6 db = new DatabaseEntities6();

            Header h = transactionFactory.createHeader(userId, staffId, date);

            db.Headers.Add(h);
            db.SaveChanges();

            return h;
        }

        public static List<Header> getAllHeader(int userId)
        {

            DatabaseEntities6 db = new DatabaseEntities6();



            List<Header> h = (from x in db.Headers where x.UserId.Equals(userId) select x).ToList();

            return h;
        }

    }
}
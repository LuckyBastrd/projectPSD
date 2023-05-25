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

            DatabaseEntities5 db = new DatabaseEntities5();

            Header h = transactionFactory.createHeader(userId, staffId, date);

            db.Headers.Add(h);
            db.SaveChanges();

            return h;
        }

        public static List<Header> getAllHeader()
        {

            DatabaseEntities5 db = new DatabaseEntities5();

            List<Header> h = (from x in db.Headers select x).ToList();

            return h;
        }

    }
}
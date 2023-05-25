using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Factory;
using TugasLabAkhir.Model;

namespace TugasLabAkhir.Repository
{
    public class detailRepository
    {

        public static Detail showDetail(string headerId, string ramenId, string quantity)
        {

            DatabaseEntities5 db = new DatabaseEntities5();

            Detail d = detailFactory.createDetail(headerId, ramenId, quantity);

            db.Details.Add(d);
            db.SaveChanges();

            return d;
        }

        public static List<Detail> getAllDetail()
        {

            DatabaseEntities5 db = new DatabaseEntities5();

            List<Detail> d = (from x in db.Details select x).ToList();

            return d;
        }

    }
}
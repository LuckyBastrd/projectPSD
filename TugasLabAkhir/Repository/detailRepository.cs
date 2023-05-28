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

        public static Detail insertDetail(int headerId, int ramenId, int quantity)
        {

            DatabaseEntities db = new DatabaseEntities();

            Detail d = detailFactory.createDetail(headerId, ramenId, quantity);

            db.Details.Add(d);
            db.SaveChanges();

            return d;
        }

        public static List<Detail> getAllDetail()
        {

            DatabaseEntities db = new DatabaseEntities();

            List<Detail> d = (from x in db.Details select x).ToList();

            return d;
        }

        public static List<Detail> sumQuantity(int headerId)
        {
            DatabaseEntities db = new DatabaseEntities();

            List <Detail> detail = (from x in db.Details where x.HeaderId.Equals(headerId) select x).ToList();

            return detail;
        }

    }
}
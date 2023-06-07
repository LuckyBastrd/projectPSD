using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Model;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.Handler
{
    public class detailHandler
    {
        public static Detail insertDetail(int headerId, int ramenId, int quantity)
        {

            return detailRepository.insertDetail(headerId, ramenId, quantity);

        }

        public static int totalPrice(int ramenId, int Quantity)
        {
            DatabaseEntities db = new DatabaseEntities();

            int totalPrice = 0;

            int Price = (from x in db.Ramen where x.RamenId == ramenId select x.Price).FirstOrDefault();

            totalPrice = Price * Quantity;

            return totalPrice;
        }
    }
}
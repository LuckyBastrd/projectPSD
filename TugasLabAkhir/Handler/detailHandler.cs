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

        public static List<TransactionDetail> getTransactionData(int? headerId = null)
        {
            return detailRepository.getTransactionData(headerId);
        }

        //Sum Logic
        public static int getSubTotalPrice(int ramenId, int Quantity)
        {
            DatabaseEntities db = new DatabaseEntities();

            int subTotalPrice = 0;

            int Price = (from x in db.Ramen where x.RamenId == ramenId select x.Price).FirstOrDefault();

            subTotalPrice = Price * Quantity;

            return subTotalPrice;
        }
    }
}
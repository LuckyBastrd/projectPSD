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

        public static int getSubTotalPrice(int ramenId, int Quantity)
        {
            DatabaseEntities db = new DatabaseEntities();

            int subTotalPrice = 0;

            int Price = (from x in db.Ramen where x.RamenId == ramenId select x.Price).FirstOrDefault();

            subTotalPrice = Price * Quantity;

            return subTotalPrice;
        }

        public static List<TransactionDetail> getTotalPrices(List<TransactionDetail> transaction)
        {
            var TrGroup = transaction.GroupBy(x => x.HeaderId).Select(group => new
            {
                HeaderId = group.Key,

                sumSubTotal = group.Sum(x => x.subTotal)
            });


            foreach (var i in TrGroup)
            {
                var transactionDetails = transaction.Where(x => x.HeaderId == i.HeaderId);

                foreach (var j in transactionDetails)
                {
                    j.totalPrice = i.sumSubTotal;
                }
            }

            return transaction;
        }

        public static List<TransactionDetail> getGrandPrices(List<TransactionDetail> transaction)
        {
            int sumTotalPrice = transaction.Sum(x => x.subTotal);

            transaction.ForEach(x => x.grandPrice = sumTotalPrice);

            return transaction;
        }
    }
}
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

        public static List<TransactionDetail> getTransactionData(int headerId)
        {
            DatabaseEntities db = new DatabaseEntities();

            List<Detail> d = (from x in db.Details where x.HeaderId.Equals(headerId) select x).ToList();

            List<TransactionDetail> transaction = d.Select(x => new TransactionDetail
            {
                HeaderId = x.HeaderId,
                userName = x.Header.User.UserName,
                staffId = x.Header.StaffId.ToString(),
                ramenName = x.Raman.RamenName,
                Broth = x.Raman.Broth,
                totalPrice = totalPrice(x.RamenId, x.Quantity),
                Quantity = x.Quantity,
                Date = x.Header.Date
            }).ToList();

            return transaction;
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
    public class TransactionDetail
    {
        public int HeaderId { get; set; }
        public string userName { get; set; }
        public string staffId { get; set; }
        public string ramenName { get; set; }
        public string Broth { get; set; }
        public int totalPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Controller;
using TugasLabAkhir.Factory;
using TugasLabAkhir.Handler;
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

        public static List<TransactionDetail> getTransactionData(int? headerId = null)
        {
            DatabaseEntities db = new DatabaseEntities();

            List<Detail> d;

            if (headerId.HasValue)
            {
                d = (from x in db.Details where x.HeaderId.Equals(headerId.Value) select x).ToList();
            }

            else
            {
                d = (from x in db.Details select x).ToList();
            }

            List<TransactionDetail> transaction = d.Select(x => new TransactionDetail
            {
                HeaderId = x.HeaderId,
                Date = x.Header.Date,
                userName = x.Header.User.UserName,
                staffId = x.Header.StaffId.ToString(),
                staffName = userController.getStaffName(x.Header.StaffId.ToString()),
                ramenName = x.Raman.RamenName,
                Broth = x.Raman.Broth,
                Quantity = x.Quantity,
                subTotalPrice = detailHandler.getSubTotalPrice(x.RamenId, x.Quantity)
            }).ToList();

            return transaction;
        }
    }

    public class TransactionDetail
    {
        public int HeaderId { get; set; }
        public DateTime Date { get; set; }
        public string userName { get; set; }
        public string staffId { get; set; }
        public string staffName { get; set; }
        public string ramenName { get; set; }
        public string Broth { get; set; }
        public int Quantity { get; set; }
        public int subTotalPrice { get; set; }
    }
}
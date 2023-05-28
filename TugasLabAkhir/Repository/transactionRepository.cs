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

            return h;
        }

        public static int getNewesttHeaderId()
        {
            DatabaseEntities db = new DatabaseEntities();
            
            int headerId = db.Headers.OrderByDescending(x => x.HeaderId).Select(x => x.HeaderId).FirstOrDefault();

            return headerId;
        }

        public static List<Transaction> getTransactionData(int userId)
        {
            List<Header> h = transactionRepository.getDataById(userId);

            List<Transaction> transaction = h.Select(x => new Transaction
            {
                HeaderId = x.HeaderId,
                userName = x.User.UserName,
                staffId = x.StaffId.ToString(),
                Date = x.Date,
                totalItem = totalItem(x.HeaderId)
            }).ToList();

            return transaction;
        }

        public static List<Header> getDataById(int userId)
        {

            DatabaseEntities db = new DatabaseEntities();

            List<Header> h = new List<Header>();

            if (userId == 1)
            {
                h = (from x in db.Headers select x).ToList();
            }

            else 
            {
                h = (from x in db.Headers where x.UserId.Equals(userId) select x).ToList();
            }
           
            return h;
        }

        public static int totalItem(int headerId)
        {
            int totalItem = 0;

            DatabaseEntities db = new DatabaseEntities();

            totalItem = db.Details.Where(x => x.HeaderId == headerId).Sum(x => x.Quantity);

            return totalItem;
        }

    }
    public class Transaction
    {
        public int HeaderId { get; set; }
        public string userName { get; set; }
        public string staffId { get; set; }
        public DateTime Date { get; set; }
        public int totalItem { get; set; }
    }
}
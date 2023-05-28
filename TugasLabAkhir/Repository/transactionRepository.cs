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

        public static Header updateStaff(int headerId, int staffId)
        {
            DatabaseEntities db = new DatabaseEntities();

            Header h = db.Headers.Find(headerId);

            if(h != null)
            {
                h.StaffId = staffId;

                db.SaveChanges();
            }

            return h;
        }

        public static int getNewesttHeaderId()
        {
            DatabaseEntities db = new DatabaseEntities();
            
            int headerId = db.Headers.OrderByDescending(x => x.HeaderId).Select(x => x.HeaderId).FirstOrDefault();

            return headerId;
        }

        public static (List<Transaction> transactionUnhandled, List<Transaction> transactionHandled) getTransactionData(int userId)
        {
            List<Header> h = transactionRepository.getDataById(userId);

            List<Transaction> transactionUnhandled = h.Where(x => x.StaffId == null).Select(x => new Transaction
            {
                HeaderId = x.HeaderId,
                userName = x.User.UserName,
                staffId = x.StaffId.ToString(),
                Date = x.Date,
                totalItem = totalItem(x.HeaderId)
            }).ToList();

            List<Transaction> transactionHandled = h.Where(x => x.StaffId != null).Select(x => new Transaction
            {
                HeaderId = x.HeaderId,
                userName = x.User.UserName,
                staffId = x.StaffId.ToString(),
                Date = x.Date,
                totalItem = totalItem(x.HeaderId)
            }).ToList();

            return (transactionUnhandled, transactionHandled);
        }

        public static List<Header> getDataById(int userId)
        {

            DatabaseEntities db = new DatabaseEntities();

            List<Header> h = new List<Header>();

            if (userId == 1 || userId == 2)
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
            DatabaseEntities db = new DatabaseEntities();

            int totalItem = 0;

            totalItem = db.Details.Where(x => x.HeaderId == headerId).Sum(x => x.Quantity);

            return totalItem;
        }

        //public static List<Header> getTransactionByStatus(int userId, int staffId)
        //{
        //    DatabaseEntities db = new DatabaseEntities();

        //    List<Header> t = (from x in db.Headers where x.StaffId.Equals(staffId) select x).ToList();

        //    return t;
        //}

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
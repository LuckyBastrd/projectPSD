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

            int headerId = (from x in db.Headers orderby x.HeaderId descending select x.HeaderId).FirstOrDefault();

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
                staffName = userController.getStaffName(x.StaffId.ToString()),
                Date = x.Date,
                totalItem = transactionHandler.totalItem(x.HeaderId),
                TrStatus = "Unhandled"
            }).ToList();

            List<Transaction> transactionHandled = h.Where(x => x.StaffId != null).Select(x => new Transaction
            {
                HeaderId = x.HeaderId,
                userName = x.User.UserName,
                staffId = x.StaffId.ToString(),
                staffName = userController.getStaffName(x.StaffId.ToString()),
                Date = x.Date,
                totalItem = transactionHandler.totalItem(x.HeaderId),
                TrStatus = "Handled"
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
    }

    public class Transaction
    {
        public int HeaderId { get; set; }
        public string userName { get; set; }
        public string staffId { get; set; }
        public string staffName { get; set; }
        public DateTime Date { get; set; }
        public int totalItem { get; set; }
        public string TrStatus { get; set; }

    }
}
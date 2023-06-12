using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Model;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.Handler
{
    public class transactionHandler
    {
        public static Header insertTransaction(string userId, string date)
        {
            return transactionRepository.insertTransaction(userId, date);
        }

        public static Header updateStaff(int headerId, int staffId)
        {
            return transactionRepository.updateStaff(headerId, staffId);
        }

        public static (List<Transaction> transactionUnhandled, List<Transaction> transactionHandled) getTransactionData(int userId)
        {
            return transactionRepository.getTransactionData(userId);
        }

        //Sum Logic
        public static int totalItem(int headerId)
        {
            DatabaseEntities db = new DatabaseEntities();

            int totalItem = 0;

            totalItem = db.Details.Where(x => x.HeaderId == headerId).Sum(x => x.Quantity);

            return totalItem;
        }
    }
}
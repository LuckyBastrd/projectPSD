using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Handler;
using TugasLabAkhir.Model;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.Controller
{
    public class transactionController
    {
        public static Header inserTransaction(string userId, string date)
        {
            return transactionHandler.insertTransaction(userId, date);
        }

        public static Header updateStaff(int headerId, int staffId)
        {
            return transactionHandler.updateStaff(headerId, staffId);
        }

        public static (List<Transaction> transactionUnhandled, List<Transaction> transactionHandled) getTransactionData(int userId)
        {
            return transactionHandler.getTransactionData(userId);
        }

    }
}
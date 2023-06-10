using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Handler;
using TugasLabAkhir.Model;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.Controller
{
    public class detailController
    {
        public static Detail insertDetail(int headerId, int ramenId, int quantity)
        {
            return detailHandler.insertDetail(headerId, ramenId, quantity);
        }

        public static List<TransactionDetail> getTransactionData(int? headerId = null)
        {
            return detailHandler.getTransactionData(headerId);
        }
    }
}
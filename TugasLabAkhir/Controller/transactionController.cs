using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Model;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.Controller
{
    public class transactionController
    {

        public static Header inserTransaction(string userId, string date)
        {
            return transactionRepository.insertTransaction(userId, date);
        }

        public static Header updateStaff(int headerId, int staffId)
        {
            return transactionRepository.updateStaff(headerId, staffId);
        }

    }
}
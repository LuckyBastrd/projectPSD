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

        public static Header showHeader(string userId, string staffId, string date)
        {

            return transactionRepository.showHeader(userId, staffId, date);

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Model;

namespace TugasLabAkhir.Factory
{
    public class transactionFactory
    {
        public static Header createHeader(string userId, string date)
        {

            Header h = new Header();
            
            h.UserId = int.Parse(userId);
            h.Date = DateTime.Parse(date);

            return h;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Model;

namespace TugasLabAkhir.Handler
{
    public class transactionHandler
    {


        public static int totalItem(int headerId)
        {
            DatabaseEntities db = new DatabaseEntities();

            int totalItem = 0;

            totalItem = db.Details.Where(x => x.HeaderId == headerId).Sum(x => x.Quantity);

            return totalItem;
        }
    }
}
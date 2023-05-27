using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Model;

namespace TugasLabAkhir.Factory
{
    public class detailFactory
    {

        public static Detail createDetail(int headerId, int ramenId, int quantity)
        {

            Detail d = new Detail();
            

            d.HeaderId = headerId;
            d.RamenId = ramenId;
            d.Quantity = quantity;

            return d;
        }

    }
}
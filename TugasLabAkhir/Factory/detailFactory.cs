using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Model;

namespace TugasLabAkhir.Factory
{
    public class detailFactory
    {

        public static Detail createDetail(string headerId, string ramenId, string quantity)
        {

            Detail d = new Detail();

            d.HeaderId = int.Parse(headerId);
            d.RamenId = int.Parse(ramenId);
            d.Quantity = int.Parse(quantity);

            return d;
        }

    }
}
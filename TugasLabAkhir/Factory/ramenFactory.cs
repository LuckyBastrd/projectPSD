using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Model;

namespace TugasLabAkhir.Factory
{
    public class ramenFactory
    {

        public static Raman createRamen(string ramenName, string meat, string broth, string price)
        {

            Raman r = new Raman();

            r.RamenName = ramenName;
            r.MeatId = int.Parse(meat);
            r.Broth = broth;
            r.Price = int.Parse(price);

            return r;
        }

    }
}
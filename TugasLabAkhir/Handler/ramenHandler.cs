using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.Handler
{
    public class ramenHandler
    {

        public static string insertRamen(string ramenName, string meat, string broth, string price)
        {
            return ramenRepository.insertRamen(ramenName, meat, broth, price);
        }

    }
}
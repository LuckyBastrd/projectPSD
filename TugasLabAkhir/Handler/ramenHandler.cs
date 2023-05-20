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

        public static string updateRamen(string id, string ramenName, string meat, string broth, string price)
        {
            return ramenRepository.updateRamen(id, ramenName, meat, broth, price);
        }

        public static Boolean deleteRamen(string id)
        {
            return ramenRepository.deleteRamen(id);
        }

    }
}
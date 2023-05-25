using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Model;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.Controller
{
    public class detailController
    {

        public static Detail showDetail(string headerId, string ramenId, string quantity)
        {

            return detailRepository.showDetail(headerId, ramenId, quantity);

        }

    }
}
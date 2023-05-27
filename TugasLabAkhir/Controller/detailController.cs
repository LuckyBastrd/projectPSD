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

        public static Detail insertDetail(int headerId, int ramenId, int quantity)
        {

            return detailRepository.insertDetail(headerId, ramenId, quantity);

        }

    }
}
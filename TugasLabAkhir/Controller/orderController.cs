using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Handler;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.Controller
{
    public class orderController
    {
        public static List<RamenItem> getRamenItem()
        {
            return orderHandler.getRamenItem();
        }
    }
}
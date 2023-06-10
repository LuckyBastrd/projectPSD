using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.Handler
{
    public class orderHandler
    {
        public static List<RamenItem> getRamenItem()
        {
            return orderRepository.getRamenItem();
        }
    }
}
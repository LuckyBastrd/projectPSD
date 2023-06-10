using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Controller;
using TugasLabAkhir.Model;

namespace TugasLabAkhir.Repository
{
    public class orderRepository
    {
        public static List<RamenItem> getRamenItem()
        {
            List<Raman> r = ramenController.getAllRamen();

            List<RamenItem> ramenItem = r.Select(x => new RamenItem
            {
                RamenId = x.RamenId,
                RamenName = x.RamenName,
                MeatName = x.Meat.MeatName.ToString(),
                Broth = x.Broth,
                Price = x.Price
            }).ToList();

            return ramenItem;
        }
    }

    public class RamenItem
    {
        public int RamenId { get; set; }
        public string RamenName { get; set; }
        public string Broth { get; set; }
        public string MeatName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
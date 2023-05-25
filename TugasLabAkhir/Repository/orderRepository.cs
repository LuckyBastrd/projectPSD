using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasLabAkhir.Model;

namespace TugasLabAkhir.Repository
{
    public class orderRepository
    {
        public static List<RamenItem> getRamenItem()
        {
            List<Raman> r = ramenRepository.getAllRamen();

            List<RamenItem> ramenItem = r.Select(x => new RamenItem
            {
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
        public string RamenName { get; set; }
        public string Broth { get; set; }
        public string MeatName { get; set; }
        public decimal Price { get; set; }
    }
}
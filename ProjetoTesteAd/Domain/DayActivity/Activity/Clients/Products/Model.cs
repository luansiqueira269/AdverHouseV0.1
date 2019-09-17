using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoTesteAd.Domain.DayActivity.Activity.Clients.Products
{
    public class Model
    {
        public int ProductId { get; set; }
        public decimal Time { get; set; }
        public string Name { get; set; }
        public bool Aproval { get; set; }
        public Campaigns.Model[] Campaign { get; set; }
    }
}
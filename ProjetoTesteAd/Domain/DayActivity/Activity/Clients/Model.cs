using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoTesteAd.Domain.DayActivity.Activity.Clients
{
    public class Model
    {
        public int ClientId { get; set; }
        public decimal Time { get; set; }
        public string Name { get; set; }
        public bool Aproval { get; set; }
        public Products.Model[] Product { get; set; }
    }
}
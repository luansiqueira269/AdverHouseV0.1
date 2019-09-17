using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoTesteAd.Domain.DayActivity.Activity.Clients.Products.Campaigns
{
    public class Model
    {
        public decimal Time { get; set; }
        public string Name { get; set; }
        public bool Aproval { get; set; }
        public int CampaingId { get; set; }
        public Jobs.Model[] Job { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoTesteAd.Domain.Activity.Clients
{
    public class Model
    {
        public DateTime Date { get; set; }
        public string Holding { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public bool Aproval { get; set; }
        public Campaigns.Model[] Campaign { get; set; }
        public Jobs.Model[] Job { get; set; }
        public Products.Model[] Product { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoTesteAd.Domain.DayActivity.Activity
{
    public class Model
    {
        public DateTime Date { get; set; }
        public string Holding { get; set; }
        public string Department { get; set; }
        public Clients.Model[] Client { get; set; }
    }
}
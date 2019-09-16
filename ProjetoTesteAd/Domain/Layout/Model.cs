using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoTesteAd.Domain.Layout
{
    public class Model
    {
        public Users.List.Model[] Users { get; set; }
        public Holding.List.Model[] Holdings { get; set; }
        public Department.List.Model[] Departments { get; set; }
        public UsersGroup.List.Model[] UsersGroups { get; set; }
        public Team.List.Model[] Teams { get; set; }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjetoTesteAd.Controllers
{
    public class SearchController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get([FromUri] DateTime startdate, DateTime enddate)
        {

            var activitys = Domain.Activity.Service.GetClients(startdate,enddate);

            return Json(new { activitys }, new Newtonsoft.Json.JsonSerializerSettings
            {
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
            });
        }

    }
}

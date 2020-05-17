using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LocationCellAPI.Controllers
{
    public class LocationController : ApiController
    {
        // GET: api/Location
        public IEnumerable<string> Get()
        {
            return new string[] { "value10", "value20" };
        }

        // GET: api/Location/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Location
        public void Post([FromBody]string value)
        {
        }
    }
}

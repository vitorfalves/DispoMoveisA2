using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LocationCellAPI.Controllers
{
    public class SensorController : ApiController
    {
        // GET: api/Sensor
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Sensor/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Sensor
        public void Post([FromBody]string value)
        {
        }

    }
}

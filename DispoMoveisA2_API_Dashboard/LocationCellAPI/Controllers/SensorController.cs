using LocationCellAPI.JSON.Input;
using LocationCellAPI.ORM;
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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        [ActionName("DefaultAction")]
        public string Post(JsonSensor jsonSensor)
        {
            try
            {
                SensorDAO.InitializeInsertSensor(jsonSensor);
            }
            catch (Exception ex)
            {

            }
            return "Sensor";
        }

    }
}

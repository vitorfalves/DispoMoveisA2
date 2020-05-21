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
    public class LocationSensorController : ApiController
    {
        [HttpPost]
        [ActionName("DefaultAction")]
        public string Post(JsonLocationSensor jsonLocationSensor)
        {
            try
            {
                LocationSensorDAO.InitializeInsertLocationSensor(jsonLocationSensor);
            }
            catch (Exception ex)
            {

            }
            return "LocationSensor";
        }
    }
}

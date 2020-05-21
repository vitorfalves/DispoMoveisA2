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
    public class LocationController : ApiController
    {
        // GET: api/Location
        [HttpGet]
        [ActionName("DefaultAction")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value10", "value20" };
        }

        [HttpGet]
        public string Teste()
        {
            return "value10";
        }

        // GET: api/Location/5
        public string Get(int id)
        {
            return "value";
        }

        //[ActionName("DefaultAction")] <-- UTILIZAR QUANDO A ACTION FOR O PRÓPRIO CONTROLADOR -->
        [HttpPost]
        [ActionName("DefaultAction")]
        public string Post(JsonLocation jsonLocation)
        {
            try
            {
                LocationDAO.InitializeInsertLocation(jsonLocation);
            }
            catch (Exception ex)
            {

            }
            return "Location";
        }
    }
}

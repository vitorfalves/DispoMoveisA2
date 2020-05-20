using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationCellAPI.Models
{
    public class Location
    {
        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Bairro { get; set; }

        public string Rua { get; set; }

        public string Pais { get; set; }
    }
}
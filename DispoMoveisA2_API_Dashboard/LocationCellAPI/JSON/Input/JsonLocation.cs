using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace LocationCellAPI.JSON.Input
{
    public class JsonLocation
    {
        [JsonProperty("Cidade")]
        public string Cidade { get; set; }

        [JsonProperty("Estado")]
        public string Estado { get; set; }

        [JsonProperty("Bairro")]
        public string Bairro { get; set; }

        [JsonProperty("Rua")]
        public string Rua { get; set; }

        [JsonProperty("Altitude")]
        public string Altitude { get; set; }

        [JsonProperty("Longitude")]
        public string Longitude { get; set; }
    }
}
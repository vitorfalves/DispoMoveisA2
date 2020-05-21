using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationCellAPI.JSON.Input
{
    public class JsonSensor
    {
        [JsonProperty("Luminosidade")]
        public string Luminosidade { get; set; }

        [JsonProperty("Temperatura")]
        public string Temperatura { get; set; }

        [JsonProperty("Umidade")]
        public string Umidade { get; set; }

        [JsonProperty("Proximidade")]
        public string Proximidade { get; set; }
    }
}
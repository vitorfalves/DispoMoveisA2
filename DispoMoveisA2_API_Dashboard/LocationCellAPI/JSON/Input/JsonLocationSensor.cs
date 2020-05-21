using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationCellAPI.JSON.Input
{
    public class JsonLocationSensor
    {
        [JsonProperty("Cidade")]
        public string Cidade { get; set; }

        [JsonProperty("Estado")]
        public string Estado { get; set; }

        [JsonProperty("Bairro")]
        public string Bairro { get; set; }

        [JsonProperty("Rua")]
        public string Rua { get; set; }

        [JsonProperty("Pais")]
        public string Pais { get; set; }

        [JsonProperty("Latitude")]
        public string Latitude { get; set; }

        [JsonProperty("Longitude")]
        public string Longitude { get; set; }

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
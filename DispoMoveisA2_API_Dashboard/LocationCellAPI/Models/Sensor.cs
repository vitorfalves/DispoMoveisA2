﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationCellAPI.Models
{
    public class Sensor
    {
        public string Luminosidade { get; set; }

        public string Temperatura { get; set; }

        public string Umidade { get; set; }

        public string Proximidade { get; set; }
    }
}
﻿using PClienteEstudiante.view.bodywork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClienteEstudiante.view.automobile
{
    internal class Automobile
    {
        public int id { get; set; }
        public string brand { get; set; }
        public decimal price { get; set; }
        public string snid { get; set; }
        public bool absBrake { get; set; }
        public List<Bodywork> bodyworks { get; set; }
        public DateTime arrivalDate { get; set; }
    }
}

using PClienteEstudiante.view.bodywork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClienteEstudiante.view.searchedAutomobile
{
    internal class Automobile
    {
        public int id { get; set; }
        public string brand { get; set; }
        public decimal price { get; set; }
        public string snid { get; set; }
        public bool absBrake { get; set; }
        public Bodywork bodywork { get; set; }
        public DateTime arrivalDate { get; set; }
    }
}

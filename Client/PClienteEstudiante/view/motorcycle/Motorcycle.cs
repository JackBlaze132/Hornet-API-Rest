using System;

namespace PClienteEstudiante.view.motorcycle
{
    public class Motorcycle
    {
        public int id { get; set; }
        public string brand { get; set; }
        public decimal price { get; set; }
        public string snid { get; set; }
        public bool absBrake { get; set; }
        public string forkType { get; set; }
        public bool helmetIncluded { get; set; }
        public DateTime arrivalDate { get; set; }
    }
}
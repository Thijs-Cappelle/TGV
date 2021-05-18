using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TGV.ViewModels
{
    public class RitVM
    {
        public string Start { get; set; }
        public string Bestemming { get; set; }
        public DateTime Vertrek { get; set; }
        public DateTime Aankomst { get; set; }
        public int AtlPlaatsen { get; set; }
        public double BasisPrijs { get; set; }
    }
}

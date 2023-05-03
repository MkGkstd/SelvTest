using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selv_TesterApp
{
    public class Brus
    {
        public string? Navn { get; set; }
        public int? Pris { get; set; }

        public Brus(string navn, int pris)
        {
            Navn = navn;
            Pris = pris;
        }

        public override string? ToString() 
        {
            return $"Navne på vare:{Navn}\n Pris på varen:{Pris}SH";
        }

    }
}

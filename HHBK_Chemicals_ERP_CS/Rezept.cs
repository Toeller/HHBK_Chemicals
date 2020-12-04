using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class Rezept
    {
        private int rezeptnummer;
        private int herstellungsdauerMin;
        private int produkt_Artikelnummer;

        public int Rezeptnummer { get; set; }
        public int HerstellungsdauerMin { get; set; }   
        public int Produkt_Artikelnummer { get; set; }
    }
}

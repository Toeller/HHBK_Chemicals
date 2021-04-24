using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IControllerRechnungErstellen
    {

        int Rechnungspositionsnummer { get; }
        int Rechnungsnummer { get;  }
        // TODO BestellPosition existiert zurzeit nicht, weswegen ich vorerst dynamic verwende.
        public dynamic BestellPosition { get; }
        // TODO Artikel existiert zurzeit nicht, weswegen ich vorerst dynamic verwende.
        public dynamic Artikel { get; }
        // TODO Kunde existiert zurzeit nicht, weswegen ich vorerst dynamic verwende.
        public dynamic Kunde { get; }


    }
}

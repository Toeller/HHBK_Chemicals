using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerRechnungErstellen : IControllerRechnungErstellen
    {
        public int Rechnungspositionsnummer { get; private set; }
        public int Rechnungsnummer { get; private set; }
        // TODO BestellPosition existiert zurzeit nicht, weswegen ich vorerst dynamic verwende.
        public dynamic BestellPosition { get; private set; }
        // TODO Artikel existiert zurzeit nicht, weswegen ich vorerst dynamic verwende.
        public dynamic Artikel { get; private set; }
        // TODO Kunde existiert zurzeit nicht, weswegen ich vorerst dynamic verwende.
        public dynamic Kunde { get; private set; }




        public ControllerRechnungErstellen(int rechnungspositionsnummer,
                                           int rechnungsnummer,
                                           dynamic bestellPosition,
                                           dynamic artikel,
                                           dynamic kunde)
        {
            Rechnungspositionsnummer = rechnungspositionsnummer;
            Rechnungsnummer = rechnungsnummer;
            BestellPosition = bestellPosition;
            Artikel = artikel;
            Kunde = kunde;
        }

    }
}

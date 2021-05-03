using System;

namespace HHBK_Chemicals_ERP_CS
{
    /// <summary>
    /// Bestellposition:
    /// Enthelt alle spalten des Bestellpositions Tabelles:
    /// 
    ///Bestellpositionsnummer INT
    ///Bestellungsnummer INT
    ///Menge INT
    ///Bestelldatum DATE
    ///Produkt_Artikelnummer1 INT(FK)
    ///Kunde_Kundennummer INT(FK)
    ///Lieferposition_idLieferposition INT(FK)
    ///
    /// </summary>
    public class Bestellposition
    {
        /// <summary>
        /// Die Konstruktor nimt als parameter alle vorhandene spalten.
        /// </summary>
        /// <param name="bestellpositionsnummer">Bestellpositionsnummer INT</param>
        /// <param name="bestellungsnummer">Bestellungsnummer INT</param>
        /// <param name="menge">Menge INT</param>
        /// <param name="bestelldatum">Bestelldatum DATE</param>
        /// <param name="produktArtikelnummer1">Produkt_Artikelnummer1 INT (FK)</param>
        /// <param name="kundeKundennummer">Kunde_Kundennummer INT (FK)</param>
        /// <param name="lieferpositionidLieferposition">Lieferposition_idLieferposition INT (FK)</param>
        public Bestellposition(int bestellpositionsnummer, int bestellungsnummer, int menge, DateTime bestelldatum, int produktArtikelnummer1, int kundeKundennummer, int lieferpositionidLieferposition)
        {
            Bestellpositionsnummer = bestellpositionsnummer;
            Bestellungsnummer = bestellungsnummer;
            Menge = menge;
            Bestelldatum = bestelldatum;
            Produkt_Artikelnummer1 = produktArtikelnummer1;
            Kunde_Kundennummer = kundeKundennummer;
            Lieferposition_idLieferposition = lieferpositionidLieferposition;
        }
        public Bestellposition()
        {

        }

        public int Bestellpositionsnummer { set; get; }
        public int Bestellungsnummer { set; get; }
    
        public int Menge { set; get; }
        
        public DateTime Bestelldatum { set; get; }

        public int Produkt_Artikelnummer1 { get; set;}

        public int Kunde_Kundennummer { get; set; }

        public int Lieferposition_idLieferposition { get; set; }

        /// <summary>
        /// Gipt ein string mit alle werten in reinefole: 
        /// Bestellpositionsnummer, Bestellungsnummer, Menge, Bestelldatum, Produkt_Artikelnummer1, Kunde_Kundennummer, Lieferposition_idLieferposition
        /// zürück
        /// </summary>
        /// <returns>Bestellpositionsnummer, Bestellungsnummer, Menge, Bestelldatum, Produkt_Artikelnummer1, Kunde_Kundennummer, Lieferposition_idLieferposition</returns>
        public override string ToString()
        {
            return $"Bestellpositionsnummer: {Bestellpositionsnummer}, Bestellungsnummer {Bestellungsnummer}, Menge {Menge}, Bestelldatum {Bestelldatum}, Produkt_Artikelnummer1 {Produkt_Artikelnummer1}, Kunde_Kundennummer {Kunde_Kundennummer}, Lieferposition_idLieferposition {Lieferposition_idLieferposition}";
        }
    }
}
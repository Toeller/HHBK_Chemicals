using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IControllerProduction
    {
        int Produktionspositionsnummer { get; }
        int Produkt_Artikelnummer { get; }
        DateTime DatumProduktionsfreigabe { get; }
        DateTime DatumProduktion { get; }
        char NameProdkutionsfreigabe { get; }
        char NameProduzent { get; }
        int Bestellposition_Bestellpositionsnummer { get; set; }
        int Bestellposition_Kunde_Kundennummer { get; set; }
    }
}

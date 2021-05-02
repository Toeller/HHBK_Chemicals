using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IViewBestellung
    {
        int Bestellpositionsnummer
        {
            get; set;
        }
        int Bestellungsnummer
        {
            get; set;
        }
        int Mengee
        {
            get; set;
        }
        DateTime Bestelldatum
        {
            get; set;
        }
        int Artikelnummer
        {
            get; set;
        }
       int  Kundennummer{
         get; set;
                }
        int Lieferposition
        {
            get; set;
        }
        decimal Preis
        {
            get; set;
        }

    }
    
}

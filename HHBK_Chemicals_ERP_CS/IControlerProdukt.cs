using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IControlerProdukt
    {
      Produkt ProduktnameAusgeben(int Artikelnummer);
      Produkt ArtikelnameAusgeben(int Artikelname);
      Produkt VerkaufseiunheitAusgeben(int Verkaufseinheit);
      Produkt EinheitAusgeben(string Einheit);
      Produkt PreisVkAusgeben(double PreisVk);


         















    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IModel
    {
        //Kunde
        Kunde GetKunde(int Kundennummer);

        Lieferposition GetLieferposition(int idLieferposition);


    }
}

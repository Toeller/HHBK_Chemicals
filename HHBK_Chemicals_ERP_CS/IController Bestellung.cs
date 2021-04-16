using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IController_Bestellung
    {
        int Anlegen(Bestellung bestellung);
        int Andern(Bestellung bestellung, Bestellung newBestellung);
        int loschen(Bestellung bestellung);
    }
}

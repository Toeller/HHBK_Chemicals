using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    interface IControllerBestellung
    {
        IModel IModel1 { set; }
        IViewBestellung IViewBestellung1 { set; }

        void bestellungSpeichern(List<Bestellposition> bestellung);
    }
}

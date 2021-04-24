using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerZahlungseingangpruefen : IControllerZahlungseingangpruefen
    {
        private IControllerZahlungseingangpruefen controllerZahlungseingangpruefen;
        IControllerZahlungseingangpruefen IControllerZahlungseingangpruefen.IControllerZahlungseingangpruefen { set => this.controllerZahlungseingangpruefen=value; }
    }
}

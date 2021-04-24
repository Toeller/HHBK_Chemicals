using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerZahlungseingangpruefen : IControllerZahlungseingangpruefen
    {
        private IModel model;
        private IViewZahlungseingangpruefen viewZahlungseingangpruefen;
        IViewZahlungseingangpruefen IControllerZahlungseingangpruefen.IViewZahlungseingangpruefen1 { set => this.viewZahlungseingangpruefen=value; }
        IModel IControllerZahlungseingangpruefen.IModel1 { set => this.model=value; }
    }
}

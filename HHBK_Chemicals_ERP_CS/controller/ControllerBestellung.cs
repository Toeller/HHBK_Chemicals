using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerBestellung:IControllerBestellung
    {
        private IModel model;
        private IViewBestellung viewBestellung;

        IViewBestellung IControllerBestellung.IViewBestellung1 { set => this.viewBestellung=value; }
        IModel IControllerBestellung.IModel1 { set => this.model=value; }

        void IControllerBestellung.bestellungSpeichern(List<Bestellposition> bestellung)
        {
            model.bestellungSpeichern(bestellung);
        }
    }
}

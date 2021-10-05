using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class Controller : IController
    {
        private IModel model;
        private IView view;
        IModel IController.IModel1 { set => this.model = value; }
        IView IController.IView1 { set => this.view = value; }

        void IController.bestellungSpeichern(List<Bestellposition> bestellung)
        {
            model.bestellungSpeichern(bestellung);
        }

        //View(view).ViewProduktionFreigegeben += onProduktionFreigegeben;
        private void doStuff(){
        //View(this.view).
        
        }
    }
}

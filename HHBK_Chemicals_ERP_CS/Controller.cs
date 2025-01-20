using HHBK_Chemicals_ERP_CS.model;
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
        IModel IController.IModel { set => this.model = value; }
        IView IController.IView { set => this.view = value; }

        private VerfahrenstechnischesModel verfahrenstechnischesModel;

        public Controller()
        {
            verfahrenstechnischesModel = new VerfahrenstechnischesModel();
        }

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

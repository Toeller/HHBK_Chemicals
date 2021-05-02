using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerBestellung : IController_Bestellung
    {
        private Model Model;
        private View_Bestellung View_Bestellung;
        Model IController_Bestellung.Model { set => Model = value; }
        View_Bestellung IController_Bestellung.View_Bestellung { set => View_Bestellung = value; }

        int IController_Bestellung.Andern(Bestellung bestellung, Bestellung newBestellung)
        {
            throw new NotImplementedException(); //model.EdBestellung(Bestellung bestellung,Bestellung newBestellung)
        }

        int IController_Bestellung.Anlegen(Bestellung bestellung)
        {
            throw new NotImplementedException(); //model.GetBestellung(Bestellung bestellung)
        }

        int IController_Bestellung.Loeschen(Bestellung bestellung)
        {
            throw new NotImplementedException(); //model.RmBestellung(Bestellung bestellung)
        }
    }
}

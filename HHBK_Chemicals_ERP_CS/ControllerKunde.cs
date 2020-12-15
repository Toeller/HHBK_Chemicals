using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class ControllerKunde : IControllerKunde
    {
        private IModel model;
        IModel IControllerKunde.Model { 
            get => model;
            set => model=value; }

        void IControllerKunde.speichern(Kunde kunde)
        {
            if (kunde.Kundennummer == 0)
            {
                model.KundeAnlegen(kunde);
            }
            else
            {
                model.KundeAendern(kunde);
            }
        }

        Kunde IControllerKunde.suchen(int kundennummer)
        {
            return model.KundeLesen(kundennummer);
        }
    }
}

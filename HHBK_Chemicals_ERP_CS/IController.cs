using System.Collections.Generic;

namespace HHBK_Chemicals_ERP_CS
{
    public interface IController
    {
        IModel IModel { set; }
        IView IView { set; }
        
        void bestellungSpeichern(List<Bestellposition> bestellung);

        


    }
}
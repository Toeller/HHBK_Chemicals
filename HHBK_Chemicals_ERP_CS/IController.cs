using System.Collections.Generic;

namespace HHBK_Chemicals_ERP_CS
{
    public interface IController
    {
        IModel IModel1 { set; }
        IView IView1 { set; }
        
        void bestellungSpeichern(List<Bestellposition> bestellung);

        


    }
}